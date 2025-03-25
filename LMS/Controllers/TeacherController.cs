using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using models.DTO.AccountDTO;
using models.DTO.AssistantDTO;
using models.Model;

namespace lms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Teacher , Assistant")]
    public class TeacherController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        private readonly UserManager<AppUser> _userManager;

        public TeacherController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<AppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
        }

        [HttpGet("Assistant")]
        public async Task<IActionResult> GetAssistant(){
            IGenericRepository<Assistant> assistantRepository = _unitOfWork.Repository<Assistant>();
            List<Assistant> assistants = await assistantRepository.GetAllAsync();
            List<ViewAssistantDTO> viewAssistants = _mapper.Map<List<ViewAssistantDTO>>(assistants);
            return Ok(viewAssistants);
        }

        [HttpGet("Assistant/{id}")]
        public async Task<IActionResult> GetAssistant(Guid id){
            IGenericRepository<Assistant> assistantRepository = _unitOfWork.Repository<Assistant>();
            Assistant assistant = await assistantRepository.GetByIdAsync(id);
            ViewAssistantDTO viewAssistant = _mapper.Map<ViewAssistantDTO>(assistant);
            return Ok(viewAssistant);
        }

        [HttpPost("Assistant")]
        public async Task<IActionResult> AddAssistant([FromBody]  AssistantRegisterDTO assistant){
            var result = await _userManager.CreateAsync(_mapper.Map<Assistant>(assistant), assistant.Password);
            if(result.Succeeded){
                var result2 = await _userManager.AddToRoleAsync(_mapper.Map<Assistant>(assistant), "Assistant");
                return Ok("Assistant Added Successfully");
            }else{
                return BadRequest(result.Errors);
            }
        }


    }
}
