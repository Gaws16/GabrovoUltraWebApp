using GabrovoUltraWebApp.Core.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using GabrovoUltraWebApp.Infrastructure.Models.DTO;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.ImportDTO;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistancesController : ControllerBase
    {
        private readonly IDistanceService distanceService;
        private readonly IMapper mapper;
        public DistancesController(IDistanceService _distanceService, IMapper _mapper)
        {
            distanceService = _distanceService;
            mapper = _mapper;
        }

        // GET: api/Distances
        //Get all distances
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async  Task<IActionResult> GetAll()
        {
            //Fetch data from the service
            var distances = await distanceService.GetAllAsync();
            //Map the data to DTO and send to client
            return Ok(mapper.Map<List<DistanceDTO>>(distances));
        }
        // GET: api/Distances/id=5
        //Get distance by id
        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var distance = await distanceService.GetByIdAsync(id);
            if (distance == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<DistanceDTO>(distance));
        }

        // POST: api/Distances
        //Create a new distance
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public async Task<IActionResult> Create([FromBody] CreateDistanceRequestDTO distanceDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Map the DTO to data
            var distance = mapper.Map<Distance>(distanceDTO);
            //Send the data to the service
           var createdDistance = await distanceService.CreateAsync(distance);
            if (createdDistance == null)
            {
                return NotFound();
            }
            //Map the data to DTO and send to client
            var distanceDTOToReturn = mapper.Map<DistanceDTO>(distance);
            return CreatedAtAction(nameof(GetById), new { id = createdDistance.Id }, distanceDTOToReturn);
        }


        [HttpPut]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateDistanceRequestDTO distanceDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //Map the DTO to data
            var distanceToUpdate = mapper.Map<Distance>(distanceDTO);
            //Send the data to the service
            var updatedDistance = await distanceService.UpdateAsync(id, distanceToUpdate);
            if (updatedDistance == null)
            {
                return NotFound();
            }
            //Map the data to DTO and send to client
            var distanceToReturn = mapper.Map<DistanceDTO>(updatedDistance);

            return Ok(mapper.Map<DistanceDTO>(distanceToReturn));
        }
        //DELETE: api/Distances/id=5
        //Delete distance by id
        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var distance = await distanceService.DeleteAsync(id);
            if (distance == null)
            {
                return NotFound();
            }
           var distanceDTOToReturn = mapper.Map<DistanceDTO>(distance);
            return Ok(distanceDTOToReturn);
        }
    }
}
