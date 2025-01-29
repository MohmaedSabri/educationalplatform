using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace models.Model;

public class Answer
{   
    public Guid Id { get; set; }
   public string AnswerValue { get; set; }
   public Guid QuestionId { get; set; }
   public Guid StudentId { get; set; }
    public virtual Question Question { get; set; }

    public virtual Student Student { get; set; }

}
