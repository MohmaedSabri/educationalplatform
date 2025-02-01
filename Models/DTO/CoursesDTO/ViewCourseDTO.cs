using System;
using System.Text.Json.Serialization;

namespace models.DTO.CoursesDTO;

public class ViewCourseDTO
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public decimal Price { get; set; }
    
    public int Year { get; set; }
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }


    public List<ViewLessonDTO> Lessons { get; set; } = null;

    
}
