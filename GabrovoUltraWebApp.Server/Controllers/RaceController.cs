using AutoMapper;
using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.ImportDTO;
using GabrovoUltraWebApp.Server.CustomActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private readonly IRaceService raceService;
        private readonly IMapper mapper;
        public RaceController(IRaceService _raceService, IMapper _mapper)
        {
            raceService = _raceService;
            mapper = _mapper;
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
        [HttpPost]
        [ValidateDate]
        [ValidateModelState]
        public async Task<IActionResult> Create([FromBody] CreateRaceRequestDTO createRaceRequestDTO)
        {
           
           var raceToCreate= mapper.Map<Race>(createRaceRequestDTO);

            await raceService.CreateAsync(raceToCreate);

            return CreatedAtAction(nameof(GetById), new { id = raceToCreate.Id }, raceToCreate);
        }

    }
}
