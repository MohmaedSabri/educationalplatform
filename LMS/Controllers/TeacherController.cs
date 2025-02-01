using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public TeacherController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("Assistant")]
        public async Task<IActionResult> GetAssistant(){
            IGenericRepository<Assistant> assistantRepository = _unitOfWork.Repository<Assistant>();
            List<Assistant> assistants = await assistantRepository.GetAllAsync();
            List<ViewAssistantDTO> viewAssistants = _mapper.Map<List<ViewAssistantDTO>>(assistants);
            return Ok(viewAssistants);
        }


    }
}
