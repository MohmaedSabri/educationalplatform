using System.Security.Claims;
using AutoMapper;
using lms.AuthenticationServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using models.DTO.AccountDTO;
using models.DTO.LoginDTO;
using models.Model;

namespace lms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        private readonly IAuthenticationService _authenticationService;

        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(IUnitOfWork unitOfWork, IMapper mapper, SignInManager<AppUser> signInManager,
            IAuthenticationService authenticationService, UserManager<AppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _signInManager = signInManager;
            _userManager = userManager;
            _authenticationService = authenticationService;
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] RequestLoginDTO loginDTO){
            var user = await _userManager.FindByNameAsync(loginDTO.Email);

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDTO.Password, false);
            if(result.Succeeded){
                var roles = await _userManager.GetRolesAsync(user);
                List<Claim> claims = new List<Claim>{
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.UserName!),
                };

                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }
                string token = _authenticationService.GenerateToken(claims);
                string refreshToken = _authenticationService.GenerateRefreshToken();

                user.RefreshToken = refreshToken;
                user.RefreshTokenExpiryTime = DateTime.Now.AddDays(14);
                await _unitOfWork.Repository<AppUser>().UpdateAsync(user);
                await _unitOfWork.CommitAsync();
                ResponseLoginDTO response = new ResponseLoginDTO(){
                    Token = token,
                    RefreshToken = refreshToken,
                    Id = user.Id
                };
                return Ok(response);
            }else{
                return Unauthorized("Invalid username or password");
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RequestStudentRegisterDTO registerDTO){
            var user = _mapper.Map<Student>(registerDTO);
            user.RefreshToken = _authenticationService.GenerateRefreshToken();
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(14);
            var result = await _userManager.CreateAsync(user, registerDTO.Password);
            result = await _userManager.AddToRoleAsync(user, "Student");
            if(result.Succeeded){
                RequestLoginDTO loginDTO = new RequestLoginDTO(){
                    Email = registerDTO.Email,
                    Password = registerDTO.Password
                };
                return await Login(loginDTO);
            }else{
                return BadRequest(result.Errors);
            }
        }


    }
}
