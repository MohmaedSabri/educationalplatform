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

    [Required]
    public string ImageUrl { get; set; }

    [Required]

    public decimal Price { get; set; }

    [Required]
    [Range(1,6)]
    public int Year { get; set; }


    public DateTime StartDate { get; set; } = DateTime.UtcNow.ToLocalTime();

    public DateTime EndDate { get; set; } = DateTime.UtcNow.ToLocalTime();

    


}
