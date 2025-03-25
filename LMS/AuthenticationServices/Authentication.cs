

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using lms.AuthenticationServices;
using Microsoft.IdentityModel.Tokens;



public class Authentication : IAuthenticationService
{
    private readonly IConfiguration _configuration;

    public Authentication(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string GenerateRefreshToken()
    {
        return Guid.NewGuid().ToString();
    }

    public string GenerateToken(List<Claim> claims, int minutes)
    {
        SymmetricSecurityKey key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
        SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddMinutes(minutes),
            SigningCredentials = creds
        };

        JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
        SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
        
    }


    public bool IsTokenValid(string token)
    {
        if (token == null) return false;

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]!);
        try
        {
            var JwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token)!;
            List<Claim> claims = JwtToken.Claims.ToList<Claim>();
            if(claims.Count == 0) return false;

            foreach (var claim in claims)
            {
                if(claim.Type == ClaimTypes.Expired){
                    if(DateTime.Parse(claim.Value) > DateTime.Now) return true;
                }
            }
            return false;
        }
        catch
        {
            return false;
        }
    }
}