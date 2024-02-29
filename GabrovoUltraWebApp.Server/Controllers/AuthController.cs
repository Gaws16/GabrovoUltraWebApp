using GabrovoUltraWebApp.Server.Models;
using GabrovoUltraWebApp.Server.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
                this.authService = authService;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(LoginRequestModel user)
        {
            if (await authService.RegisterUser(user))
            {
            return Ok("Succesfully registered!");
            }
            return BadRequest("romething went wrong!");

        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequestModel user)
        {
            if(ModelState.IsValid == false)
            {
                return BadRequest("Invalid data");
            }
            var result =  await authService.LoginUser(user);

            if(result)
            {
                //var token sssssss swwwwiwenerateJwtTokenuser);
                //Response.Cookies.Append("jwt", token, new CookieOptions
                //{
                //    HttpOnly = true
                //});
                return Ok("Done");
            }
            return BadRequest();
        }


    }
}
