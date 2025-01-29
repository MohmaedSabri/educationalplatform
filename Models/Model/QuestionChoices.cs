using System;

namespace models.Model;

public class QuestionChoices
{
    public Guid Id { get; set; }
    public string Choice { get; set; }
    public Guid QuestionId { get; set; }

    public virtual Question Question { get; set; }
    
}
