using System;

namespace models.DTO.ExamDTO;

public class ViewExamDTO
{
    public Guid Id{get;set;}

    public string Title {get;set;}

    public DateTime StartDate {get;set;}

    public int DurationInMinutes {get;set;}

    public string ExamToken {get;set;}

    public List<ViewQuestionDTO> Questions {get;set;}


}
