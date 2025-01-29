using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace models.Model;


public class Student : AppUser
{
   public string FName{ get; set; }
   public string SName{ get; set; }
   public string TName{ get; set; }
   public int year{ get; set; }
   public string ParentPhone{ get; set; }
    public virtual List<Course> Courses{ get; set; }

    public virtual List<Exam> Exams{ get; set; }

    public virtual List<StudentCourse> StudentCourses{ get; set; }
    public virtual List<Answer> Answers{ get; set; }

    public virtual List<Payment> Payments{ get; set; }
    
    

}
