using System;

namespace models.Model;

public class ExamSession
{
    public  Guid Id { get; set; }
    public DateTime StartDate { get; set; }
    public Guid ExamId { get; set; }
    public Exam Exam { get; set; }

    public Guid StudentId { get; set; }
    public Student Student { get; set; }

}
