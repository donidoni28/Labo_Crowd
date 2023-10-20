using CrowdFounding_labo.Models;
using Labo_CrowdFunding.api;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CrowdFounding_labo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private  IJwtAuthenticationService _jwt { get; }
    private IConfiguration _config { get; }
    public AuthenticationController(IJwtAuthenticationService jwt, IConfiguration config)
    {
        _jwt = jwt;
        _config = config;
    }

    [HttpPost]
    public IActionResult Login([FromBody] LoginModel model)
    {
        var user = _jwt.Authenticate(model.Email, model.Password);
        if(user is not null)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),

            };
            var token = _jwt.GenerateToken(_config["Jwt:Key"],claims);
            return Ok(token);
        }
        return Unauthorized();
    }
}
