using System;
using System.ComponentModel.DataAnnotations;

namespace models.DTO.AccountDTO;

public class AssistantRegisterDTO
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Password { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string PhoneNumber { get; set; }


}
