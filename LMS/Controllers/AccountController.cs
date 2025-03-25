using System.IdentityModel.Tokens.Jwt;
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
public async Task<IActionResult> Login([FromBody] RequestLoginDTO loginDTO)
{
    // Find the user by email
    var user = await _userManager.FindByEmailAsync(loginDTO.Email);

    // Ensure user exists
    if (user == null)
    {
        return Unauthorized(new { message = "Invalid username or password" });
    }

    // Verify password
    if (!await _userManager.CheckPasswordAsync(user, loginDTO.Password))
    {
        return Unauthorized(new { message = "Invalid username or password" });
    }

    // Get user roles
    var roles = await _userManager.GetRolesAsync(user);
    
    if (roles == null || roles.Count == 0)
    {
        return BadRequest(new { message = "User has no assigned roles" });
    }

    // Create claims
    List<Claim> claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new Claim(ClaimTypes.Name, user.UserName ?? ""),
        new Claim(JwtRegisteredClaimNames.Aud, "http://localhost"),
        new Claim(JwtRegisteredClaimNames.Iss, "http://localhost"),
    };

    foreach (var role in roles)
    {
        claims.Add(new Claim(ClaimTypes.Role, role));
    }

    // Generate JWT and Refresh Token
    string token = _authenticationService.GenerateToken(claims, 5);
    string refreshToken = _authenticationService.GenerateRefreshToken();

    // Save Refresh Token in the user entity
    user.RefreshToken = refreshToken;
    user.RefreshTokenExpiryTime = DateTime.Now.AddDays(14);

    await _unitOfWork.Repository<AppUser>().UpdateAsync(user);
    await _unitOfWork.CommitAsync();

    // Prepare response
    ResponseLoginDTO response = new ResponseLoginDTO()
    {
        Token = token,
        RefreshToken = refreshToken,
        Id = user.Id,
        Email = user.Email
    };

    return Ok(new
    {
        data = response,
        message = "Login successful"
    });
}

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RequestStudentRegisterDTO registerDTO){
            var user = _mapper.Map<Student>(registerDTO);
            user.RefreshToken = _authenticationService.GenerateRefreshToken();
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(14);
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.Id = Guid.NewGuid();
            var result = await _userManager.CreateAsync(user, registerDTO.Password);

            if(result.Succeeded){
                var result2 = await _userManager.AddToRoleAsync(user, "Student");
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
