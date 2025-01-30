using System;
using models.DTO.CoursesDTO;

namespace models.DTO.StudentDTO;

public class ViewStudentDTO
{
    public Guid Id { get; set; }

    public string FName { get; set; }

    public string LName { get; set; }

    public string TName { get; set; }

    public int year { get; set; }

    public string Phone { get; set; }

    public string ParentPhone { get; set; }

    public string Address { get; set; }

    public string Gender { get; set; }
    public string Email { get; set; }

    public List<ViewCourseDTO> Courses { get; set; }

}
