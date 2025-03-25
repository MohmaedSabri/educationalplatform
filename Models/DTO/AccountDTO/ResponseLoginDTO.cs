using System;

namespace models.DTO.LoginDTO;

public class ResponseLoginDTO
{
    public Guid Id { get; set; }

    public string Token{ get; set; }

    public string RefreshToken{ get; set;}

    public string Email { get; set; }



}
