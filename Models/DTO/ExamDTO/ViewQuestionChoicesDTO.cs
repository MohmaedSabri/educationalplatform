using System;

namespace models.DTO.ExamDTO;

public class ViewQuestionChoicesDTO
{
    public Guid Id{get; set;}

    public string Choice{get; set;}

    public List<ViewQuestionChoicesDTO> QuestionChoices{get; set;}
}
