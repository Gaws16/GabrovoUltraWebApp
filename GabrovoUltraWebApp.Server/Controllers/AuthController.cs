using GabrovoUltraWebApp.Infrastructure.Models;
using GabrovoUltraWebApp.Core.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            return BadRequest("Something went wrong!");

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
               var token = authService.GenerateTokenString(user);
               var response = JsonConvert.SerializeObject(new { token });
                return Ok(response);
            }
            return BadRequest();
        }


    }
}
