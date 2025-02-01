using System;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;

namespace models.Model;

public class AppUser : IdentityUser<Guid>
{

    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }
}
