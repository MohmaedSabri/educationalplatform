using System;
using System.ComponentModel.DataAnnotations;

namespace models.Model;

public class Exam
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }

    public Guid CourseId { get; set; }
    virtual public Course Course { get; set; }

    virtual public ICollection<Question> Questions { get; set; }

}
