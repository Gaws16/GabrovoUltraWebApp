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
        [HttpPost("register")]
        public async Task<IActionResult> Register(LoginRequestModel user)
        {
            return Ok(await authService.RegisterUser(user));
        }
    }
}
