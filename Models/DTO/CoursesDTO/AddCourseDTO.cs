using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using models.Model;

namespace models.DTO.CoursesDTO;

public class AddCourseDTO
{   
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public DateTime StartDate { get; set; } = DateTime.UtcNow.ToLocalTime();

    


}
