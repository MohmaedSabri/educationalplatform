using System;

namespace models.DTO.ExamDTO;

public class AddQuestionDTO
{
    public string QuestionDescription { get; set; } 

    public string Answer { get; set; }

    public List<AddQuestionChoicesDTO> Choices { get; set; }
    



}
