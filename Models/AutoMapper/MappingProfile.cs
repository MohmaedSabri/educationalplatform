using System;
using System.Runtime.InteropServices;
using AutoMapper;
using models.DTO.CoursesDTO;
using models.DTO.ExamDTO;
using models.DTO.PaymentDTO;
using models.DTO.StudentDTO;
using models.Model;

namespace models.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Course, ViewCourseDTO>();
        CreateMap<AddCourseDTO, Course>();
        
        CreateMap<Lesson, ViewLessonDTO>();
        CreateMap<AddLessonDTO, Lesson>();

        CreateMap<Exam, ViewExamDTO>();
        CreateMap<AddExamDTO, Exam>();

        CreateMap<Question, ViewQuestionDTO>();
        CreateMap<AddQuestionDTO, Question>();

        CreateMap<QuestionChoices, ViewQuestionChoicesDTO>();
        CreateMap<AddQuestionChoicesDTO, QuestionChoices>();

        CreateMap<Student, ViewStudentDTO>();


        CreateMap<Payment, ViewPaymentDTO>().ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Title));
    }

}
