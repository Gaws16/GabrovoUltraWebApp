using GabrovoUltraWebApp.Core.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private readonly IRaceService raceService;
        public RaceController(IRaceService _raceService)
        {
            raceService = _raceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var racers= await  raceService.GetAllAsync();
            return Ok(racers);
        }
    }
}
