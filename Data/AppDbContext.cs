using System;
using data.ModelConfigurations;
using data.ModelConfigurations.CourseConfiguration.cs;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using models.Model;

namespace data;

public class AppDbContext : IdentityDbContext<AppUser,Role,Guid>
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<QuestionChoices> QuestionChoices { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public DbSet<Coupon> Coupons { get; set; }
    public DbSet<Assistant> Assistants { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
        


    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new StudentConfiguration());
        builder.ApplyConfiguration(new CourseConfiguration());
        builder.ApplyConfiguration(new LessonConfiguration());
        builder.ApplyConfiguration(new QuestionConfiguration());
        builder.ApplyConfiguration(new AnswerConfiguration());
        builder.ApplyConfiguration(new QuestionChoicesConfiguration());
        builder.ApplyConfiguration(new PaymentConfiguration());
        builder.ApplyConfiguration(new ExamConfiguration());
        builder.ApplyConfiguration(new StudentCourseConfiguration());
        builder.ApplyConfiguration(new CouponConfiguration());
    }

}
