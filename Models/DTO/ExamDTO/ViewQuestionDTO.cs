using System;

namespace models.DTO.ExamDTO;

public class ViewQuestionDTO
{
    public Guid Id{ get; set; }

    public string QuestionDescription { get; set; }
    public List<ViewQuestionChoicesDTO> Choices { get; set; }

}
