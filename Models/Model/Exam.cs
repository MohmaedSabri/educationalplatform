using System;
using System.ComponentModel.DataAnnotations;

namespace models.Model;

public class Exam
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime StartDate { get; set; }

    public int DurationInMinutes { get; set; }
    public Guid CourseId { get; set; }
    virtual public Course Course { get; set; }

    virtual public List<Question> Questions { get; set; }

    virtual public List<ExamSession> ExamSessions { get; set; }

}
