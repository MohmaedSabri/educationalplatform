using System;
using AutoMapper;
using models.DTO.CoursesDTO;
using models.Model;

namespace models.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Course, ViewCourseDTO>();
        CreateMap<ViewCourseDTO, Course>();
        CreateMap<AddCourseDTO, Course>();
    }

}
