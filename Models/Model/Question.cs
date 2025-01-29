using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace models.Model;

public class Question
{
    public Guid Id { get; set; }
   public Guid ExamId { get; set; }
   public string QuestionDescription { get; set; }
   public string Answer { get; set; }
    public virtual List<QuestionChoices> QuestionChoices { get; set; }

    public virtual List<Answer> Answers { get; set; }
    public virtual Exam Exam { get; set; }

}
