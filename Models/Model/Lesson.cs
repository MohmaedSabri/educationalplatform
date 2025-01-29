using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace models.Model;

[Index(nameof(Id),IsUnique = true) ]

public class Lesson
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
   public string VideoUrl { get; set; }
   public string PdfUrl { get; set; }
    public bool IsFree { get; set; }
    public DateTime CreatedAt { get; set; }

    public Guid CourseId { get; set; }

    public Course Course { get; set; }



}
