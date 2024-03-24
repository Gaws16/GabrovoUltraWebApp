using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Models.ImportDTO;
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
        // GET: api/Race
        // Get all races
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var racers= await  raceService.GetAllAsync();
            return Ok(racers);
        }

        //GET: api/Race/id=5
        //Get race by id
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
            => Ok(await raceService.GetByIdAsync(id));

        //POST: api/Race/
        //Create a new race
        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] CreateRaceRequestDTO createRaceRequestDTO)
        //{

        //}

    }
}
