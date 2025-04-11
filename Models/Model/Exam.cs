using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace models.Model;

public class Exam
{
    public Guid Id { get; set; }
    
    [Column(TypeName = "nvarchar(250)")]
    public string Title { get; set; }
    public DateTime StartDate { get; set; }

    public int DurationInMinutes { get; set; }
    public Guid CourseId { get; set; }
    virtual public Course Course { get; set; }

    virtual public List<Question> Questions { get; set; }

    virtual public List<ExamSession> ExamSessions { get; set; }

}
