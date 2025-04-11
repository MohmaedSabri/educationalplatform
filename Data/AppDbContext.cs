using System;
using data.ModelConfigurations;
using data.ModelConfigurations.CourseConfiguration.cs;
using Microsoft.AspNetCore.Identity;
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

        List<Role> roles = new List<Role>{
            new Role{Id = Guid.NewGuid(), Name = "Student", NormalizedName = "STUDENT" },
            new Role{Id = Guid.NewGuid(), Name = "Assistant", NormalizedName = "ASSISTANT" },
            new Role{Id = Guid.NewGuid(), Name = "Teacher", NormalizedName = "TEACHER" }
        };

        var admin = new AppUser
        {
            Id = Guid.NewGuid(),
            UserName = "Admin",
            NormalizedUserName = "ADMIN",
            Email = "Admin@admin.com",
            NormalizedEmail = "ADMIN@ADMIN.COM",
            EmailConfirmed = true,
            SecurityStamp = string.Empty,
        };

        var passwordHasher = new PasswordHasher<AppUser>();
        admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin@1234");

        List<AppUser> users = new List<AppUser> { admin };

        var adminRole = new IdentityUserRole<Guid>
        {
            UserId = admin.Id,
            RoleId = roles[2].Id
            
        };

        

        builder.Entity<Role>().HasData(roles);
        builder.Entity<AppUser>().HasData(users);
        builder.Entity<IdentityUserRole<Guid>>().HasData(adminRole);

        // Seed Students with Arabic names
        var students = new List<Student>();
        var studentRole = roles[0].Id;
        var arabicFirstNames = new[] { "محمد", "أحمد", "عمر", "علي", "يوسف", "عبدالله", "إبراهيم", "حسن", "خالد", "زياد" };
        var arabicSecondNames = new[] { "محمود", "السيد", "العربي", "حسين", "مصطفى", "عثمان", "الشافعي", "إسماعيل", "عبدالرحمن", "المصري" };
        var arabicLastNames = new[] { "أحمد", "محمد", "علي", "حسن", "عبدالعزيز", "السيد", "إبراهيم", "العربي", "مصطفى", "محمود" };

        for (int i = 0; i < 10; i++)
        {
            var studentId = Guid.NewGuid();
            var student = new Student
            {
                Id = studentId,
                UserName = $"student{i + 1}",
                NormalizedUserName = $"STUDENT{i + 1}",
                Email = $"student{i + 1}@example.com",
                NormalizedEmail = $"STUDENT{i + 1}@EXAMPLE.COM",
                EmailConfirmed = true,
                SecurityStamp = string.Empty,
                FName = arabicFirstNames[i],
                SName = arabicSecondNames[i],
                TName = arabicLastNames[i],
                year = 2024,
                ParentPhone = $"0100{Random.Shared.Next(1000000, 9999999)}"
            };
            student.PasswordHash = passwordHasher.HashPassword(student, "Student@123");
            students.Add(student);

            builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                UserId = studentId,
                RoleId = studentRole
            });
        }
        builder.Entity<Student>().HasData(students);

        // Seed Courses with Arabic content
        var courses = new List<Course>();
        var courseTitles = new[]
        {
            "الرياضيات المتقدمة للثانوية العامة",
            "الفيزياء التطبيقية للصف الثالث الثانوي",
            "الكيمياء العضوية للثانوية العامة",
            "اللغة العربية - النحو والأدب",
            "اللغة الإنجليزية - المستوى المتقدم"
        };
        var courseDescriptions = new[]
        {
            "دورة شاملة في الرياضيات تغطي المنهج الكامل للثانوية العامة مع حل مسائل وتمارين إضافية",
            "شرح مفصل للفيزياء مع التركيز على المسائل العملية والتجارب المعملية",
            "دورة متكاملة في الكيمياء العضوية مع شرح التفاعلات والمركبات الكيميائية",
            "دورة متخصصة في قواعد اللغة العربية والأدب مع تحليل النصوص الأدبية",
            "دورة مكثفة في اللغة الإنجليزية تشمل القواعد والمحادثة والكتابة"
        };

        for (int i = 0; i < 5; i++)
        {
            courses.Add(new Course
            {
                Id = Guid.NewGuid(),
                Title = courseTitles[i],
                Description = courseDescriptions[i],
                StartDate = DateTime.Now.AddDays(i + 1),
                EndDate = DateTime.Now.AddMonths(i + 2),
                ImageUrl = $"course{i + 1}.jpg",
                Price = (i + 1) * 500, // Prices in EGP
                Year = 2024
            });
        }
        builder.Entity<Course>().HasData(courses);

        // Seed Lessons with Arabic content
        var lessons = new List<Lesson>();
        var lessonTitles = new[]
        {
            new[] { "مقدمة وأساسيات", "المفاهيم الأساسية", "تمارين وتطبيقات", "المراجعة النهائية" },
            new[] { "القوانين الأساسية", "الحركة والقوة", "الطاقة والشغل", "التطبيقات العملية" },
            new[] { "المركبات العضوية", "التفاعلات الكيميائية", "المجموعات الوظيفية", "التجارب المعملية" },
            new[] { "قواعد النحو", "البلاغة", "تحليل النصوص", "التعبير الكتابي" },
            new[] { "القواعد المتقدمة", "مهارات المحادثة", "فهم النصوص", "الكتابة الإبداعية" }
        };

        foreach (var (course, index) in courses.Select((c, i) => (c, i)))
        {
            for (int j = 0; j < 4; j++)
            {
                lessons.Add(new Lesson
                {
                    Id = Guid.NewGuid(),
                    Title = lessonTitles[index][j],
                    Description = $"شرح تفصيلي ل{lessonTitles[index][j]} في مادة {course.Title}",
                    VideoUrl = $"video_{course.Title}_{j + 1}.mp4",
                    PdfUrl = $"lesson_{course.Title}_{j + 1}.pdf",
                    IsFree = j == 0,
                    CreatedAt = DateTime.Now,
                    CourseId = course.Id
                });
            }
        }
        builder.Entity<Lesson>().HasData(lessons);

        // Seed Exams with Arabic content
        var exams = new List<Exam>();
        foreach (var course in courses)
        {
            exams.Add(new Exam
            {
                Id = Guid.NewGuid(),
                Title = $"الاختبار النهائي - {course.Title}",
                StartDate = course.EndDate.AddDays(-7),
                DurationInMinutes = 90,
                CourseId = course.Id
            });
        }
        builder.Entity<Exam>().HasData(exams);

        // Seed Questions with Arabic content
        var questions = new List<Question>();
        var questionChoices = new List<QuestionChoices>();
        foreach (var (exam, courseIndex) in exams.Select((e, i) => (e, i)))
        {
            var questionTemplates = courseIndex switch
            {
                0 => new[] { // Math questions
                    "ما هو حل المعادلة س²+ 4س + 4 = 0؟",
                    "ما هي قيمة النهاية عندما س تقترب من 2؟",
                    "ما هو التكامل غير المحدد للدالة 2س + 1؟",
                    "ما هو مجال الدالة الجذرية √(س-1)؟",
                    "احسب مساحة المثلث الذي أطواله 3، 4، 5"
                },
                1 => new[] { // Physics questions
                    "ما هو قانون نيوتن الثالث؟",
                    "كيف تحسب الطاقة الحركية لجسم؟",
                    "ما هي وحدة قياس القوة في النظام الدولي؟",
                    "اشرح مبدأ حفظ الطاقة",
                    "ما هو قانون أوم؟"
                },
                _ => new[] { // General format for other subjects
                    $"السؤال الأول في {exam.Title}",
                    $"السؤال الثاني في {exam.Title}",
                    $"السؤال الثالث في {exam.Title}",
                    $"السؤال الرابع في {exam.Title}",
                    $"السؤال الخامس في {exam.Title}"
                }
            };

            for (int i = 0; i < 5; i++)
            {
                var questionId = Guid.NewGuid();
                questions.Add(new Question
                {
                    Id = questionId,
                    ExamId = exam.Id,
                    QuestionDescription = questionTemplates[i],
                    Answer = $"الإجابة الصحيحة {i + 1}"
                });

                // Add Arabic choices for each question
                for (int j = 0; j < 4; j++)
                {
                    questionChoices.Add(new QuestionChoices
                    {
                        Id = Guid.NewGuid(),
                        QuestionId = questionId,
                        Choice = $"الاختيار {j + 1}"
                    });
                }
            }
        }
        builder.Entity<Question>().HasData(questions);
        builder.Entity<QuestionChoices>().HasData(questionChoices);

        // Seed StudentCourses
        var studentCourses = new List<StudentCourse>();
        foreach (var student in students)
        {
            foreach (var course in courses.Take(2))
            {
                studentCourses.Add(new StudentCourse
                {
                    Id = Guid.NewGuid(),
                    StudentId = student.Id,
                    CourseId = course.Id,
                    EnrollmentDate = DateTime.Now.AddDays(-Random.Shared.Next(1, 30))
                });
            }
        }
        builder.Entity<StudentCourse>().HasData(studentCourses);

        // Seed Payments with Egyptian Pound
        var payments = new List<Payment>();
        foreach (var sc in studentCourses)
        {
            payments.Add(new Payment
            {
                Id = Guid.NewGuid(),
                StudentId = sc.StudentId,
                CourseId = sc.CourseId,
                Amount = courses.First(c => c.Id == sc.CourseId).Price,
                Status = "مكتمل",
                Date = DateTime.Now.AddDays(-Random.Shared.Next(1, 30))
            });
        }
        builder.Entity<Payment>().HasData(payments);

        // Seed Coupons with Arabic descriptions
        var coupons = new List<Coupon>();
        foreach (var course in courses)
        {
            coupons.Add(new Coupon
            {
                Id = Guid.NewGuid(),
                Code = $"خصم{course.Id.ToString().Substring(0, 5)}",
                Discount = 25,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(1),
                CourseId = course.Id
            });
        }
        builder.Entity<Coupon>().HasData(coupons);
    }
}
