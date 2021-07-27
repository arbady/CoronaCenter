using CoronaCenter.Model;
using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Services;
using CoronaCenter.Services.Services.Bases;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SecurityTools;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        //private readonly UserService userService;
        private readonly IUserService userService;
        private readonly JWTSettings jwtSettings;

        public SecurityController(IUserService userService, 
                                    IOptions<JWTSettings> jwtSettings)
        {
            this.jwtSettings = jwtSettings.Value;
            this.userService = userService;
        }

        [HttpGet]
        public ActionResult Test()
        {
            return Ok();
        }

        // POST api/<SecurityController>
        [AllowAnonymous]
        [HttpPost("[action]")]
        public ActionResult<string> Register([FromBody] UserForm form)
        {
            try
            {
                if (form is null) { return BadRequest(); }
                UserModel result = userService.Insert(form);

                return Ok("Le compte utilisateur a bien été créé.");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = "POST/Inscription",
                    Message = ex.Message
                });
            }
        }


        [AllowAnonymous]
        [HttpPost("[action]")]
        public ActionResult<UserPublic> Login(string email, string password)
        {
            try
            {
                UserPublic user = userService.Check(email, password);

                if (user is null) return StatusCode(StatusCodes.Status401Unauthorized, "L'email et le mot de passe ne correspondent à aucun profil.");

                var tokenHandler = new JwtSecurityTokenHandler();

                var key = Encoding.ASCII.GetBytes(jwtSettings.SecretKey);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim (ClaimTypes.Name, user.Email),
                        new Claim (ClaimTypes.Role, user.Role.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(10),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                                                                    SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);

                user.Token = tokenHandler.WriteToken(token);

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    Method = nameof(Login),
                    Message = ex.Message
                });
            }
        }
    } 
}
