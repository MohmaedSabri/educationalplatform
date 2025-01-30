using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using models.DTO.CoursesDTO;
using models.DTO.ExamDTO;
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
            viewCourses.ForEach(c => c.Lessons = null);
            return Ok(viewCourses);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourse(Guid id)
        {
            IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
            Course course = await courseRepository.GetByIdAsync(id,include: new string[]{"Lessons"});
            if (course.Lessons == null){
                System.Console.WriteLine("Lessons not found");
            }else{
                foreach (Lesson lesson in course.Lessons)
                {
                    System.Console.WriteLine(lesson.Title);
                }
            }
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

        [HttpPost("{id}/lessons")]
        public async Task<IActionResult> AddLesson(Guid id, [FromBody]List<AddLessonDTO> lessons){
            IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
            Course course = await courseRepository.GetByIdAsync(id);
            if (course == null)
            {
                return NotFound("Course not found");
            }
            IGenericRepository<Lesson> lessonRepository = _unitOfWork.Repository<Lesson>();
            foreach (AddLessonDTO lessonDTO in lessons)
            {
                Lesson lesson = _mapper.Map<Lesson>(lessonDTO);
                lesson.CourseId = id;
                await lessonRepository.AddAsync(lesson);
            }
            await _unitOfWork.CommitAsync();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(Guid id, [FromBody] AddCourseDTO courseDTO)
        {
            IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
            Course course = await courseRepository.GetByIdAsync(id);
            if (course == null)
            {
                return NotFound("Course not found");
            }
            _mapper.Map(courseDTO, course);
            await _unitOfWork.CommitAsync();
            return Ok("Course updated successfully");
        }

        [HttpPut("{id}/lessons/{lessonId}")]
        public async Task<IActionResult> UpdateLesson(Guid id, Guid lessonId, [FromBody] AddLessonDTO lessonDTO)
        {
            IGenericRepository<Lesson> lessonRepository = _unitOfWork.Repository<Lesson>();
            Lesson lesson = await lessonRepository.GetByIdAsync(lessonId);
            if (lesson == null)
            {
                return NotFound("Lesson not found");
            }
            _mapper.Map(lessonDTO, lesson);
            await _unitOfWork.CommitAsync();
            return Ok("Lesson updated successfully");
        }


        [HttpPost("{id}/Exam")]

        public async Task<IActionResult> AddExam(Guid id, [FromBody] AddExamDTO examDTO)
        {
            IGenericRepository<Exam> examRepository = _unitOfWork.Repository<Exam>();
            Exam exam = _mapper.Map<Exam>(examDTO);
            exam.CourseId = id;
            await examRepository.AddAsync(exam);
            await _unitOfWork.CommitAsync();
            return Ok(exam.Id);
        }

        [HttpGet("{id}/Exam")]

        public async Task<IActionResult> GetExams(Guid id)
        {
            IGenericRepository<Exam> examRepository = _unitOfWork.Repository<Exam>();
            List<Exam> exams = await examRepository.GetAllAsync();
            List<ViewExamDTO> viewExams = _mapper.Map<List<ViewExamDTO>>(exams);
            return Ok(viewExams);
        }

        

        
        
    }
}
