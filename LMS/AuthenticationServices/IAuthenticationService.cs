using System;
using System.Security.Claims;

namespace lms.AuthenticationServices;

public interface IAuthenticationService
{
    public string GenerateToken(List<Claim> claims);

    public string GenerateRefreshToken();
}