using AutoMapper;
using GabrovoUltraWebApp.Core.Services;
using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ResponseDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
using GabrovoUltraWebApp.Server.CustomActionFilters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunnerController : ControllerBase
    {
        private readonly IRunnerService runnerService;
        private readonly IMapper mapper;
        public RunnerController(IRunnerService _runnerService, IMapper _mapper)
        {
            runnerService = _runnerService;
            mapper = _mapper;
        }
        // GET: api/Runner
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll([FromQuery] string? filterOn,
            [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending,
            [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000)
        {
            var runners = await runnerService.GetAllAsync(filterOn,filterQuery,sortBy,
                isAscending,pageNumber,pageSize);
            return Ok(mapper.Map<List<RunnerDTO>>(runners));
        }

        //GET: api/Race/id=5
        //Get race by id
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var race = await runnerService.GetByIdAsync(id);
            if (race == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<RunnerDTO>(race));
        }

        //POST: api/Race/
        //Create a new race
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ValidateModelState]
        public async Task<IActionResult> Create([FromBody] CreateRunnerRequestDTO runnerRequestDTO)
        {

            var runnerToCreate = mapper.Map<Runner>(runnerRequestDTO);

           var createdRunner= await runnerService.CreateAsync(runnerToCreate);

            if(createdRunner == null)
            {
                return BadRequest();
            }

            var runnerDTO = mapper.Map<RunnerDTO>(createdRunner);

            return CreatedAtAction(nameof(GetById), new { id = runnerDTO.Id }, runnerDTO);
        }

        //PUT: api/race/id=5
        //Update Race by id
        [HttpPut]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ValidateModelState]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateRunnerRequestDTO raceRequestDTO)
        {
            var runnerToUpdate = mapper.Map<Runner>(raceRequestDTO);

            var updatedRunner = await runnerService.UpdateAsync(id, runnerToUpdate);

            if (updatedRunner == null)
            {
                return BadRequest(ModelState);
            }

            return Ok(mapper.Map<RunnerDTO>(updatedRunner));

        }
        //DELETE: api/Race/id=5
        //Delete race by id
        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deletedRunner = await runnerService.DeleteAsync(id);
            if (deletedRunner == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<RunnerDTO>(deletedRunner));
        }
    }
}
