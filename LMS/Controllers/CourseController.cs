using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using models.DTO.CoursesDTO;
using models.DTO.ExamDTO;
using models.Model;

namespace lms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class CourseController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        private readonly UserManager<AppUser> _userManager;

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
            viewCourses.ForEach(c => c.Lessons = null);
            return Ok(viewCourses);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourse(Guid id)
        {
            IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
            Course course = await courseRepository.GetByIdAsync(id,include: new string[]{"Lessons"});
            foreach (var lesson in course.Lessons)
            {
                if(lesson.IsFree == false){
                    lesson.VideoUrl = null;
                    lesson.PdfUrl = null;
                }
                
            }
            ViewCourseDTO viewCourse = _mapper.Map<ViewCourseDTO>(course);
            return Ok(viewCourse);
        } 
    }
}
