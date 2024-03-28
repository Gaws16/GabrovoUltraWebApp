using GabrovoUltraWebApp.Infrastructure.Models;
using GabrovoUltraWebApp.Core.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using GabrovoUltraWebApp.Server.CustomActionFilters;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;

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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        public async Task<IActionResult> Register(RegisterRequestDTO registerRequestDTO)
        {
            if (await authService.RegisterUser(registerRequestDTO))
            {
                //TODO inject runner controller and create runner on register
                return Ok("Succesfully registered!");
            }
            return BadRequest("Something went wrong!");

        }

        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Produces("application/json")]
        [ValidateModelState]
        public async Task<IActionResult> Login(LoginRequestDTO user)
        {
            var result = await authService.LoginUser(user);

            if (result)
            {
                var token = await authService.GenerateTokenString(user);
                var response = new LoginResponseDTO { JwtToken = token };
                return Ok(response);
            }
            return BadRequest("Username or password is incorrect!");
        }


    }
}
