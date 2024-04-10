using AutoMapper;
using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
using GabrovoUltraWebApp.Server.CustomActionFilters;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationService registrationService;
        private readonly IDistanceService distanceService;
        private readonly IMapper mapper;
        private readonly IRaceService raceService;
        private readonly IResultService resultService;
        private readonly UserManager<ApplicationUser> userManager;
        public RegistrationController(IRegistrationService _registrationService, IMapper _mapper, IDistanceService _distanceService
            , UserManager<ApplicationUser> _userManager, IRaceService _raceService, IResultService _resultService)
        {
            raceService = _raceService;
            resultService = _resultService;
            registrationService = _registrationService;
            distanceService = _distanceService;
            mapper = _mapper;
            userManager = _userManager;
        }
        // GET: api/Registration
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<IActionResult> GetAll()
        {
            //Fetch data from the service
            var registrations = await registrationService.GetAllAsync();
            //Map the data to DTO and send to client
            return Ok(mapper.Map<List<RegistrationDTO>>(registrations));
        }
        // GET: api/Registration/id=5
        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var registration = await registrationService.GetByIdAsync(id);
            if (registration == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<RegistrationDTO>(registration));
        }

       // POST: api/Registration
        [HttpPost]
        [ValidateModelState]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        
        public async Task<IActionResult> Create( [FromBody] JoinDistanceRequestDTO distanceRequest)
        {
            var distance = await distanceService.GetByIdAsync(distanceRequest.Id);

            if (distance == null)
            {
                return NotFound();
            }
            var userName = User?.FindFirstValue(ClaimTypes.Email);
            if (userName == null)
            {
                return Unauthorized();
            }
            var user = await userManager.FindByEmailAsync(userName);
            // Get the current upcoming race
            var race = await raceService.GetCurrentRaceAsync();
            if (race == null)
            {
                return BadRequest();
            }
            var registration = new Registration
            {
                DistanceId = distance.Id,
                UserId = user.Id,
                RegistrationDate = DateTime.Now,
                IsPaymentConfirmed = false,
                RaceId = race.Id,
                StartingNumber = await registrationService.GenerateStartingNumber(mapper.Map<Distance>(distance)),
                Result = new Result
                {
                    FinishTme = TimeSpan.Zero,
                    CategoryRank = 0,
                    OverallRank = 0,
                },
        };
            
            var createdRegistration = await registrationService.CreateAsync(registration, user);
                    
            if (createdRegistration == null )
            {
                //TODO Make error message file
                return BadRequest("Already registered for distance");
            }
         

            var registerResponse = mapper.Map<RegistrationDTO>(createdRegistration);
            return CreatedAtAction(nameof(GetById), new { id = registerResponse.RegistrationId }, registerResponse);
           
        }

        //PUT: api/Registration/id=5
        [HttpPut]
        [Route("{id:int}")]
        [ValidateModelState]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateRegistrationRequestDTO registrationDTO)
        {
            var registration = mapper.Map<Registration>(registrationDTO);
            var updatedRegistration = await registrationService.UpdateAsync(id, registration);
            if (updatedRegistration == null)
            {
                return NotFound();
            }
            return Ok(updatedRegistration);
        }

        // DELETE: api/Registration/id=5
        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var registration = await registrationService.DeleteAsync(id);
            if (registration == null)
            {
                return NotFound();
            }
            var responseRegistration = mapper.Map<RegistrationDTO>(registration);
            return Ok(responseRegistration);
        }

    }
}
