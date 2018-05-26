using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Invoices.Infrastructure.Commands.User;
using Invoices.Infrastructure.DTO;
using Invoices.Infrastructure.Services;
using AutoMapper;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Invoices.Api.Helpers;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace Invoices.Api.Controllers
{
    [Produces("application/json")]
    [Route("user/[action]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;

        public UserController(IUserService userService, IMapper mapper, IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [HttpPost]
        public async Task Register([FromBody]CreateUser user)
        {
            await _userService.CreateAsync(_mapper.Map<CreateUser, UserDTO>(user));
        }

        public async Task<IActionResult> Authenticate([FromBody]CreateUser user)
        {
            var _user = await _userService.AuthenticateAsync(user.Username, user.Password);
            if (_user == null)
                return Unauthorized();

            string token = CreateTokenForUser(_user);

            return Ok(new
            {
                Id = _user.Id,
                Username = _user.Username,
                Token = token
            });
        }

        private string CreateTokenForUser(UserDTO user)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}