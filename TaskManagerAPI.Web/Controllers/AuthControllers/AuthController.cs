using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TaskManagerAPI.Core.Entities.Base;
using TaskManagerAPI.Infrastructure.Interfaces;
using TaskManagerAPI.Web.APIModels.AuthDto;
using TaskManagerAPI.Web.Common;

namespace TaskManagerAPI.Web.Controllers.AuthControllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AuthController : CustomBaseController<User>
    {
        private readonly IConfiguration _configuration;
        private IUserRepository _userRepository;
        public AuthController(IUserRepository TRepository , IUserRepository userRepository, IMapper mapper , IConfiguration configuration) : base(TRepository, mapper)
        {
            _configuration = configuration;
            _userRepository = TRepository;
        }

        [HttpPost("Login")]
        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            LoginResponse loginResponse = new LoginResponse();
            string secretKey = _configuration["Secret:Secretkey"];
            var user = _userRepository.GetUserByUserName(loginRequest.UserName);
            var claims = new[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, loginRequest.UserName),
                        new Claim(ClaimTypes.Name, loginRequest.UserName),
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
            loginResponse.AccessToken = result;
            return loginResponse;
        }
    }
}
