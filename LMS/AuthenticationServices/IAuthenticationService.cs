using System;
using System.Security.Claims;

namespace lms.AuthenticationServices;

public interface IAuthenticationService
{
    public string GenerateToken(List<Claim> claims,int expiresInMinutes);

    public string GenerateRefreshToken();

    public bool IsTokenValid(string token);
}