using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TaskManagerAPI.Core.Entities.Base;

namespace TaskManagerAPI.Web.Controllers.AuthControllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {

        }

        [HttpPost("Login")]
        public async Task<string> Login(string userId , string userName , string secretKey)
        {
            const string Age = "";
            var claims = new[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, userId),
                        new Claim(ClaimTypes.Name, userName),
                        // Add other claims as needed
                    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                issuer: null, // Set the issuer if you have one
                audience: null, // Set the audience if you have one
                claims: claims,
                expires: DateTime.Now.AddHours(1), // Set the token expiration time
                signingCredentials: credentials
            );
            var result = new JwtSecurityTokenHandler().WriteToken(token);
            return result;
        }
    }
}
