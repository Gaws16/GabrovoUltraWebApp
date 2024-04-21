using AutoMapper;
using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
using GabrovoUltraWebApp.Server.CustomActionFilters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunnerController : ControllerBase
    {
        private readonly IRunnerService runnerService;
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;

        public RunnerController(IRunnerService _runnerService, IMapper _mapper, UserManager<ApplicationUser> _userManager)
        {
            runnerService = _runnerService;
            mapper = _mapper;
            userManager = _userManager;
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
            return Ok(runners);
        }
        // GET: api/Runner/count
        //Get count of all runners
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("count")]
        public async Task<IActionResult> GetCount()
        {
            var count = await runnerService.GetCountAsync();
            if (count == 0)
            {
                return NotFound();
            }
            return Ok(count);
        }

        //GET: api/Runners/id=5
        //Get runner by id
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

        //POST: api/Runner/
        //Create a new Runner
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ValidateModelState]
        public async Task<IActionResult> Create([FromBody] CreateRunnerRequestDTO runnerRequestDTO)
        {

            var runnerToCreate = mapper.Map<ApplicationUser>(runnerRequestDTO);

           var createdRunner= await runnerService.CreateAsync(runnerToCreate);

            if(createdRunner == null)
            {
                return BadRequest();
            }

            var runnerDTO = mapper.Map<RunnerDTO>(createdRunner);

            return CreatedAtAction(nameof(GetById), new { id = runnerDTO.Id }, runnerDTO);
        }

        //PUT: api/runner/id=5
        //Update Runner by id
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ValidateModelState]
        public async Task<IActionResult> Update([FromRoute] string id, [FromBody] UpdateRunnerRequestDTO raceRequestDTO)
        {
            var runnerToUpdate = mapper.Map<ApplicationUser>(raceRequestDTO);

            var updatedRunner = await runnerService.UpdateAsync(id, runnerToUpdate);

            if (updatedRunner == null)
            {
                return BadRequest(ModelState);
            }

            return Ok(mapper.Map<RunnerDTO>(updatedRunner));

        }
        //DELETE: api/Runner/id=5
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
        //GET: api/Runner/Edit
        [HttpGet]
        [Route("Edit")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [Authorize(Roles = "Reader,Writer")]
        
        public async Task<IActionResult> Edit()
        {
            var userName = User?.FindFirstValue(ClaimTypes.Email);
            if (userName == null)
            {
                return Unauthorized();
            }
            var user = await userManager.FindByEmailAsync(userName);
            if (user == null)
            {
                return NotFound();
            }
            var runnerResponse = mapper.Map<EditRunnerResponseDTO>(user);
            return Ok(runnerResponse);
        }

        [HttpPut]
        [Route("user/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = "Writer,Reader")]
        [ValidateModelState]
        public async Task<IActionResult> EditUser([FromRoute] string id, [FromBody] UpdateUserRequestDTO updateUserRequestDTO)
        {
            var userToUpdate = mapper.Map<ApplicationUser>(updateUserRequestDTO);

            var updatedRunner = await runnerService.UpdateAsync(id, userToUpdate);

            if (updatedRunner == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<RunnerDTO>(updatedRunner));
        }
    }
}
