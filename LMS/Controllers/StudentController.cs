using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using models.DTO.CoursesDTO;
using models.DTO.PaymentDTO;
using models.DTO.StudentDTO;
using models.Model;

namespace lms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Student")]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<Student> _userManager;
        private readonly IMapper _mapper;

        public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("Courses")]
        public async Task<IActionResult> GetCourses()
        {
            IGenericRepository<StudentCourse> studentCourseRepository = _unitOfWork.Repository<StudentCourse>();
            List<StudentCourse> studentCourses = await studentCourseRepository
                .GetAsync(sc => sc.StudentId == Guid.Parse(User.FindFirst("Id")!.Value!),include: new string[]{"Course","Course.Lessons"});

            List<Course> courses = studentCourses.Select(sc => sc.Course).ToList();
            List<ViewCourseDTO> viewCourses = _mapper.Map<List<ViewCourseDTO>>(courses);
            return Ok(viewCourses);
        }
        [HttpGet("Course/{id}")]
        public async Task<IActionResult> GetCourse(Guid id)
        {
            IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
            Course course = await courseRepository.GetByIdAsync(id, include: new string[] { "Lessons" });
            IGenericRepository<StudentCourse> studentCourseRepository = _unitOfWork.Repository<StudentCourse>();
            List<StudentCourse> studentCourses = await studentCourseRepository
                .GetAsync(sc => sc.StudentId == Guid.Parse(User.FindFirst("Id")!.Value!));

            foreach (var studentCourse in studentCourses)
            {
                if (studentCourse.CourseId == id)
                {
                    ViewCourseDTO viewCourse = _mapper.Map<ViewCourseDTO>(course);
                    return Ok(viewCourse);
                }else{
                    ViewCourseDTO viewCourse = _mapper.Map<ViewCourseDTO>(course);
                    foreach (var lesson in viewCourse.Lessons)
                    {
                        lesson.VideoUrl = null;
                        lesson.PdfUrl = null;
                    }
                    return Ok(viewCourse);
                }
            }
            return NotFound();
        }

        [HttpGet("Profile/{id}")]
        public async Task<IActionResult> GetProfile()
        {
            IGenericRepository<Student> studentRepository = _unitOfWork.Repository<Student>();
            Student student = await studentRepository.GetByIdAsync(Guid.Parse(User.FindFirst("Id")!.Value!));
            ViewStudentDTO viewStudent = _mapper.Map<ViewStudentDTO>(student);
            return Ok(viewStudent);
        }

        [HttpGet("Payment/{id}")]
        public async Task<IActionResult> GetPayment()
        {
            IGenericRepository<Payment> paymentRepository = _unitOfWork.Repository<Payment>();
            List<Payment> payment = await paymentRepository.GetAsync(p => p.StudentId == Guid.Parse(User.FindFirst("Id")!.Value!), include: new string[] { "Course" });
            List<ViewPaymentDTO> viewPayment = _mapper.Map<List<ViewPaymentDTO>>(payment);
            return Ok(viewPayment);
        }




    }
}
