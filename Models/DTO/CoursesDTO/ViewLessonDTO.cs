using System;

namespace models.DTO.CoursesDTO;

public class ViewLessonDTO
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string VideoUrl { get; set; }

    public string PdfUrl { get; set; }

    public DateTime CreatedAt { get; set; }

}
