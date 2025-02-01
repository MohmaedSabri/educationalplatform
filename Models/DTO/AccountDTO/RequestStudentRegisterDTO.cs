using System;
using System.ComponentModel.DataAnnotations;

namespace models.DTO.AccountDTO;

public class RequestStudentRegisterDTO
{
    [Required]
    public string FName { get; set; }
    [Required]
    public string SName { get; set; }
    [Required]
    public string TName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public string ParentPhone { get; set; }
    [Required]
    public string Password { get; set; }

    [Required]
    public int year { get; set; }

}
