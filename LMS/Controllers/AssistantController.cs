using System;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using models.DTO.CoursesDTO;
using models.DTO.ExamDTO;
using models.Model;

namespace lms.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Assistant , Teacher")]
public class AssistantController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    private readonly IMapper _mapper;

    public AssistantController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet("Courses")]
    public async Task<IActionResult> GetCourses(){
        IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
        List<Course> courses = await courseRepository.GetAllAsync(include: new string[]{"Lessons"});
        List<ViewCourseDTO> viewCourses = _mapper.Map<List<ViewCourseDTO>>(courses);
        return Ok(viewCourses);
    }

    [HttpGet("Course/{id}")]
    public async Task<IActionResult> GetCourse(Guid id){
        IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
        Course course = await courseRepository.GetByIdAsync(id, include: new string[]{"Lessons"});
        ViewCourseDTO viewCourse = _mapper.Map<ViewCourseDTO>(course);
        return Ok(viewCourse);
    }

    [HttpPost("AddCourse")]
    public async Task<IActionResult> AddCourse([FromBody] AddCourseDTO course){
        IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
        Course newCourse = _mapper.Map<Course>(course);
        await courseRepository.AddAsync(newCourse);
        await _unitOfWork.CommitAsync();
        return Ok(newCourse.Id);
    }

    [HttpPost("Cousrse/{id}/AddLesson")]
    public async Task<IActionResult> AddLesson(Guid id, [FromBody] List<AddLessonDTO> lesson){
        IGenericRepository<Lesson> lessonRepository = _unitOfWork.Repository<Lesson>();
        List<Lesson> newLessons = _mapper.Map<List<Lesson>>(lesson);
        newLessons.ForEach(l => l.CourseId = id);
        foreach (var newLesson in newLessons){
            await lessonRepository.AddAsync(newLesson);
        }
        await _unitOfWork.CommitAsync();
        return Ok(newLessons);
    }

    [HttpPut("UpdateLesson/{lessonId}")]
    public async Task<IActionResult> UpdateLesson(Guid id, Guid lessonId, [FromBody] AddLessonDTO lesson){
        IGenericRepository<Lesson> lessonRepository = _unitOfWork.Repository<Lesson>();
        Lesson newLesson = _mapper.Map<Lesson>(lesson);
        newLesson.Id = lessonId;
        await lessonRepository.UpdateAsync(newLesson);
        await _unitOfWork.CommitAsync();
        return Ok(newLesson);
    }

    [HttpDelete("DeleteLesson/{lessonId}")]
    public async Task<IActionResult> DeleteLesson(Guid lessonId){
        IGenericRepository<Lesson> lessonRepository = _unitOfWork.Repository<Lesson>();
        lessonRepository.DeleteAsync(lessonId);
        await _unitOfWork.CommitAsync();
        return Ok();
    }

    [HttpDelete("DeleteCourse/{courseId}")]
    public async Task<IActionResult> DeleteCourse(Guid courseId){
        IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
        courseRepository.DeleteAsync(courseId);
        await _unitOfWork.CommitAsync();
        return Ok();
    }

    [HttpPost("/Course/{id}/AddExam")]
    public async Task<IActionResult> AddExam(Guid CourseId,[FromBody] AddExamDTO exam){
        IGenericRepository<Exam> examRepository = _unitOfWork.Repository<Exam>();
        Exam newExam = _mapper.Map<Exam>(exam);
        newExam.CourseId = CourseId;
        await examRepository.AddAsync(newExam);
        await _unitOfWork.CommitAsync();
        return Ok(newExam.Id);
    }

    [HttpPost("Exam/{id}/AddQuestion")]
    public async Task<IActionResult> AddQuestion(Guid id, [FromBody] AddQuestionDTO question){
        IGenericRepository<Question> questionRepository = _unitOfWork.Repository<Question>();
        Question newQuestion = _mapper.Map<Question>(question);
        newQuestion.ExamId = id;
        await questionRepository.AddAsync(newQuestion);
        await _unitOfWork.CommitAsync();
        return Ok(newQuestion.Id);
    }


    [HttpDelete("DeleteQuestion/{questionId}")]
    public async Task<IActionResult> DeleteQuestion(Guid questionId){
        IGenericRepository<Question> questionRepository = _unitOfWork.Repository<Question>();
        questionRepository.DeleteAsync(questionId);
        await _unitOfWork.CommitAsync();
        return Ok();
    }

    [HttpDelete("DeleteExam/{examId}")]
    public async Task<IActionResult> DeleteExam(Guid examId){
        IGenericRepository<Exam> examRepository = _unitOfWork.Repository<Exam>();
        examRepository.DeleteAsync(examId);
        await _unitOfWork.CommitAsync();
        return Ok();
    }

    [HttpPut("UpdateQuestion/{questionId}")]
    public async Task<IActionResult> UpdateQuestion(Guid id, Guid questionId, [FromBody] AddQuestionDTO question){
        IGenericRepository<Question> questionRepository = _unitOfWork.Repository<Question>();
        Question newQuestion = _mapper.Map<Question>(question);
        newQuestion.Id = questionId;
        await questionRepository.UpdateAsync(newQuestion);
        await _unitOfWork.CommitAsync();
        return Ok(newQuestion);
    }

    [HttpPut("UpdateExam/{examId}")]
    public async Task<IActionResult> UpdateExam(Guid id, Guid examId, [FromBody] AddExamDTO exam){
        IGenericRepository<Exam> examRepository = _unitOfWork.Repository<Exam>();
        Exam newExam = _mapper.Map<Exam>(exam);
        newExam.Id = examId;
        await examRepository.UpdateAsync(newExam);
        await _unitOfWork.CommitAsync();
        return Ok(newExam);
    }

    [HttpPut("UpdateCourse/{courseId}")]
    public async Task<IActionResult> UpdateCourse(Guid id, Guid courseId, [FromBody] AddCourseDTO course){
        IGenericRepository<Course> courseRepository = _unitOfWork.Repository<Course>();
        Course newCourse = _mapper.Map<Course>(course);
        newCourse.Id = courseId;
        await courseRepository.UpdateAsync(newCourse);
        await _unitOfWork.CommitAsync();
        return Ok(newCourse);
    }




}
