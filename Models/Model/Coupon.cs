using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace models.Model;

public class Coupon
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public int Discount { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Guid CourseId { get; set; }
    virtual public Course Course { get; set; }

}
