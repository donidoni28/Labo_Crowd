using CrowdFounding_labo.Models;
using System.Security.Claims;

namespace Labo_CrowdFunding.api
{
    public interface IJwtAuthenticationService
    {
        UserModel Authenticate(string email, string password);
        string GenerateToken(string secret, List<Claim> claims);
    }
}
