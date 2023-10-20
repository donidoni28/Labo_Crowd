using CrowdFounding_labo.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Labo_CrowdFunding.api
{
    public class JwtAuthenticationService : IJwtAuthenticationService
    {

        private readonly List<UserModel> _users = new List<UserModel>()
        {
            new UserModel
            {
                IdUser = 1,
                FirstName = "Liridon",
                LastName = "Cerimi",
                Email = "liri@mail.be",
                Password = "liridon"
            },
            new UserModel
            {
                IdUser = 2,
                FirstName = "Veton",
                LastName = "Cerimi",
                Email = "vet@mail.be",
                Password = "veton"
            },
            new UserModel
            {
                IdUser = 3,
                FirstName = "Rayan",
                LastName = "Cerimi",
                Email = "rayan@mail.be",
                Password = "rayan"
            },
            new UserModel
            {
                IdUser = 4,
                FirstName = "Dorian",
                LastName = "Cerimi",
                Email = "dodo@mail.be",
                Password = "dorian"
            }
        };
        public UserModel Authenticate(string email, string password)
        {
            return _users.Where(
                u => u.Email.ToUpper().Equals(email.ToUpper())
                &&
                u.Password.ToUpper().Equals(password.ToUpper())
                ).FirstOrDefault();
        }

        public string GenerateToken(string secret, List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(
                    key,
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
