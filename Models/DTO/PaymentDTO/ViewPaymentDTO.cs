using System;

namespace models.DTO.PaymentDTO;

public class ViewPaymentDTO
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }

    public string Status { get; set; }

    public string CourseName { get; set; }
    public DateTime Date { get; set; }

}
