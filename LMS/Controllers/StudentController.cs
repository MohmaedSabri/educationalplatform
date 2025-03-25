using System.Security.Claims;
using AutoMapper;
using lms.AuthenticationServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using models.DTO.CoursesDTO;
using models.DTO.ExamDTO;
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
        private readonly UserManager<AppUser> _userManager;

        private readonly IAuthenticationService _authenticationService;
        private readonly IMapper _mapper;

        public StudentController(IUnitOfWork unitOfWork, IMapper mapper, UserManager<AppUser> userManager, IAuthenticationService authenticationService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _authenticationService = authenticationService;
        }

        [HttpGet("Courses")]
        public async Task<IActionResult> GetCourses()
        {
            IGenericRepository<StudentCourse> studentCourseRepository = _unitOfWork.Repository<StudentCourse>();
            List<StudentCourse> studentCourses = await studentCourseRepository
                .GetAsync(sc => sc.StudentId == Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)!.Value!),include: new string[]{"Course","Course.Lessons"});

            List<Course> courses = studentCourses.Select(sc => sc.Course).ToList();
            List<ViewCourseDTO> viewCourses = _mapper.Map<List<ViewCourseDTO>>(courses);
            return Ok(new { Courses = viewCourses , Message = "Success" });
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

        [HttpGet("Profile")]
        public async Task<IActionResult> GetProfile()
        {
            IGenericRepository<Student> studentRepository = _unitOfWork.Repository<Student>();
            Student student = await studentRepository.GetByIdAsync(Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)!.Value!));
            ViewStudentDTO viewStudent = _mapper.Map<ViewStudentDTO>(student);
            return Ok(viewStudent);
        }

        [HttpGet("Payment/{id}")]
        public async Task<IActionResult> GetPayment()
        {
            IGenericRepository<Payment> paymentRepository = _unitOfWork.Repository<Payment>();
            List<Payment> payment = await paymentRepository.GetAsync(p => p.StudentId == Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)!.Value!), include: new string[] { "Course" });
            List<ViewPaymentDTO> viewPayment = _mapper.Map<List<ViewPaymentDTO>>(payment);
            return Ok(viewPayment);
        }

        [HttpGet("Exam/{id}/StartExam")]

        public async Task<IActionResult> StartExam(Guid id)
        {
            IGenericRepository<ExamSession> examSessionRepository = _unitOfWork.Repository<ExamSession>();
            List<ExamSession> examSessions = await examSessionRepository.GetAsync(es => es.ExamId == id && es.StudentId == Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)!.Value!),
            include: new string[] { "Exam", "Exam.Questions","Exam.Questions.QuestionChoices"});
            if (examSessions.Count == 0){
                return Forbid();
            }
            List<Claim> claims = new List<Claim> { new Claim(ClaimTypes.NameIdentifier, User.FindFirst(ClaimTypes.NameIdentifier)!.Value!) };
            claims.Add(new Claim(ClaimTypes.Expired, DateTime.Now.AddMinutes(examSessions[0].Exam.DurationInMinutes).ToString()));
            string ExamToken = _authenticationService.GenerateToken(claims,examSessions[0].Exam.DurationInMinutes);
            ViewExamDTO viewExam = _mapper.Map<ViewExamDTO>(examSessions[0].Exam);
            viewExam.ExamToken = ExamToken;
            return Ok(viewExam);
        }

        [HttpPost("Exam/Question/{id}/SubmitAnswer")]
        public async Task<IActionResult> SubmitAnswer(Guid id, [FromBody] string answer){
            string ExamToken = Request.Headers["ExamToken"].ToString()!;
            if(!_authenticationService.IsTokenValid(ExamToken)){
                return Forbid("Time Out");
            }
            IGenericRepository<Answer> answerRepository = _unitOfWork.Repository<Answer>();
            Answer newAnswer = new Answer{
                StudentId = Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier)!.Value!),
                QuestionId = id,
                AnswerValue = answer
            };
            await answerRepository.AddAsync(newAnswer);
            await _unitOfWork.CommitAsync();
            return Ok();   
        }
    }

    
}
