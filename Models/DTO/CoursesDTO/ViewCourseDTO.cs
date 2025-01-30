using System;
using System.Text.Json.Serialization;

namespace models.DTO.CoursesDTO;

public class ViewCourseDTO
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime StartDate { get; set; }


    public List<ViewLessonDTO> Lessons { get; set; } = null;

    
}
