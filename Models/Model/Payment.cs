using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace models.Model;

public class Payment
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Guid CourseId { get; set; }
    public decimal Amount { get; set; }

    public string Status { get; set; }
    public DateTime Date { get; set; }

    public virtual Student Student { get; set; }
    public virtual Course Course { get; set; }

    

}
