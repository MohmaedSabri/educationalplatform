using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace models.DTO.CoursesDTO;

public class AddLessonDTO
{
    [Required]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }
    [Required]
    [Url]
    public string VideoUrl { get; set; }

    [Required]
    [Url]
    public string PdfUrl { get; set; }

    [Required]
    public bool IsFree { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; }



}
