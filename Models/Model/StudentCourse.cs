using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace models.Model;

public class StudentCourse
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Guid CourseId { get; set; }
    public DateTime EnrollmentDate { get; set; }

    virtual public Student Student { get; set; }
    virtual public Course Course { get; set; }
}
