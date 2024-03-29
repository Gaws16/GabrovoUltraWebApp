using AutoMapper;
using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
using GabrovoUltraWebApp.Server.CustomActionFilters;
using Microsoft.AspNetCore.Mvc;

namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;
        private readonly IRunnerService runnerService;
        private readonly IMapper mapper;

        public AuthController(IAuthService _authService, IRunnerService _runnerService, IMapper _mapper)
        {
            authService = _authService;
            runnerService = _runnerService;
            mapper = _mapper;
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
                var runner = mapper.Map<Runner>(registerRequestDTO);
                await runnerService.CreateAsync(runner);
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
