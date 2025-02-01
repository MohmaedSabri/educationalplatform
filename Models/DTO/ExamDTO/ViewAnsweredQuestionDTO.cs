using System;

namespace models.DTO.ExamDTO;

public class ViewAnsweredQuestionDTO
{
    public int Id { get; set; }
    public int QuestionId { get; set; }
    public string Answer { get; set; }
    public string StudentAnswer { get; set; }
    public List<ViewQuestionChoicesDTO> Choices { get; set; }

}
