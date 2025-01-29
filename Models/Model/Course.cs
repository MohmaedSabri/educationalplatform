
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace models.Model;

public class Course
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime StartDate { get; set; }

    public virtual List<Lesson> Lessons { get; set; }

    public virtual List<StudentCourse> StudentCourses { get; set; }
    public virtual List<Student> Students { get; set; }

    public virtual List<Payment> Payments { get; set; }

    public virtual List<Coupon> Coupons { get; set; }
    public virtual Exam Exam { get; set; }

}
