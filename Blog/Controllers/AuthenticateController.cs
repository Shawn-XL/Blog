using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Blog.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Blog.Controllers
{

    [ApiController]
    [Route("auth")] 
    public class AuthenticateController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthenticateController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("login")]
        public IActionResult login([FromBody] LoginDto loginDto)
        {
            var signingAlgorithm = SecurityAlgorithms.HmacSha256;

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, "fake_user_id")
            };

            var scretByte = Encoding.UTF8.GetBytes(_configuration["Authentications:ScretKey"]);
            var signingKey = new SymmetricSecurityKey(scretByte);
            var signingCredentials = new SigningCredentials(signingKey, signingAlgorithm);

            var token = new JwtSecurityToken(
                issuer: _configuration["Authentications:Issuer"],
                audience: _configuration["Authentications:Audience"],
                claims,
                notBefore: DateTime.UtcNow,
                expires:DateTime.UtcNow.AddDays(1),
                signingCredentials
            );

            var tokenStr = new JwtSecurityTokenHandler().WriteToken(token);

            return Ok(tokenStr);
        }
    }
}
