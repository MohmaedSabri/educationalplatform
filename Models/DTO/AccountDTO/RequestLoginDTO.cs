using System;
using System.ComponentModel.DataAnnotations;

namespace models.DTO.LoginDTO;

public class RequestLoginDTO
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }

}
