using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using models.DTO.CoursesDTO;
using models.Model;

namespace lms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CourseController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourses()
        {
            IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
            List<Course> courses = await courseRepository.GetAllAsync();
            List<ViewCourseDTO> viewCourses = _mapper.Map<List<ViewCourseDTO>>(courses);
            return Ok(viewCourses);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCourse(int id)
        {
            IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
            Course course = await courseRepository.GetByIdAsync(id);
            ViewCourseDTO viewCourse = _mapper.Map<ViewCourseDTO>(course);
            return Ok(viewCourse);
        }

        [HttpPost]
        public async Task<IActionResult> AddCourse([FromBody] AddCourseDTO courseDTO)
        {
            Course course = _mapper.Map<Course>(courseDTO);
            await _unitOfWork.Repository<Course>().AddAsync(course);
            await _unitOfWork.CommitAsync();
            return Ok();
        }
    }
}
