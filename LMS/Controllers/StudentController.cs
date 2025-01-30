using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using models.DTO.CoursesDTO;
using models.DTO.PaymentDTO;
using models.DTO.StudentDTO;
using models.Model;

namespace lms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult> GetStudents()
        {
            IGenericRepository<Student> studentRepository = _unitOfWork.Repository<Student>();
            List<Student> students = await studentRepository.GetAllAsync();
            List<ViewStudentDTO> viewStudents = _mapper.Map<List<ViewStudentDTO>>(students);
            return Ok(viewStudents);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStudent(Guid id)
        {
            IGenericRepository<Student> studentRepository = _unitOfWork.Repository<Student>();
            Student student = await studentRepository.GetByIdAsync(id,include: new string[]{"Courses","Payments"});
            ViewStudentDTO viewStudent = _mapper.Map<ViewStudentDTO>(student);
            return Ok(viewStudent);
        }

        [HttpGet("{id}/Payments")]
        public async Task<IActionResult> GetPayments(Guid id)
        {
            IGenericRepository<Student> studentRepository = _unitOfWork.Repository<Student>();
            Student student = await studentRepository.GetByIdAsync(id,include: new string[]{"Payments","Payments.Course"});
            List<Payment> payments = student.Payments.ToList();
            List<ViewPaymentDTO> viewPayments = _mapper.Map<List<ViewPaymentDTO>>(payments);
            return Ok(viewPayments);
        }

        [HttpGet("{id}/Courses")]
        public async Task<IActionResult> GetCourses(Guid id)
        {
            IGenericRepository<Student> studentRepository = _unitOfWork.Repository<Student>();
            Student student = await studentRepository.GetByIdAsync(id,include: new string[]{"Courses"});
            List<Course> courses = student.Courses.ToList();
            List<ViewCourseDTO> viewCourses = _mapper.Map<List<ViewCourseDTO>>(courses);
            return Ok(viewCourses);
        }
        
    }
}
