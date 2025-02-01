using System;
using System.ComponentModel.DataAnnotations;

namespace models.DTO.ExamDTO;

public class AddExamDTO
{
    [Required]
    public string Title { get; set; }

    [Required]
    public DateTime StartDate { get; set; }

    [Required]
    public int DurationInMinutes { get; set; }


}
