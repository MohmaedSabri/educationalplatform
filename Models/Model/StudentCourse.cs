using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace models.Model;

public class StudentCourse
{
    
    public Guid StudentId { get; set; }

    public Guid CourseId { get; set; }


    virtual public Student Student { get; set; }
    virtual public Course Course { get; set; }



}
