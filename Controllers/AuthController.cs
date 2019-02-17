using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SunflowerFund.API.Data;
using SunflowerFund.API.Dtos;
using SunflowerFund.API.models;

namespace SunflowerFund.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;
        public AuthController(IAuthRepository repo, IConfiguration config)
        {
            _config = config;
            _repo = repo;

        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDtos userForRegisterDtos)
        {
            userForRegisterDtos.Username = userForRegisterDtos.Username.ToLower();
            if (await _repo.UserExists(userForRegisterDtos.Username))
                return BadRequest("Username already exist");

            var userToCreate = new User
            {
                Username = userForRegisterDtos.Username
            };
            var createduser = await _repo.Register(userToCreate, userForRegisterDtos.Password);

            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForloginDtos userForloginDtos)
        {
            var userFromRepo = await _repo.Login(userForloginDtos.Username.ToLower(), userForloginDtos.Password);

            if (userFromRepo == null)
                return Unauthorized();

            var claims = new[]
            {
             new Claim(ClaimTypes.NameIdentifier, userFromRepo.id.ToString()),
             new Claim(ClaimTypes.Name, userFromRepo.Username)

        };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSetting:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor  =  new SecurityTokenDescriptor{
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(1),
                SigningCredentials = creds
                
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

        return Ok(new {
            token = tokenHandler.WriteToken(token)});
        }
    }
}