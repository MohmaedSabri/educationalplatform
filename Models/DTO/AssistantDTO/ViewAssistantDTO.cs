using System;

namespace models.DTO.AssistantDTO;

public class ViewAssistantDTO
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public DateTime HireDate { get; set; }

    public decimal Salary { get; set; }
}
