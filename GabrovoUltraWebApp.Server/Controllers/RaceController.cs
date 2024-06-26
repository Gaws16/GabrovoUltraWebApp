﻿using AutoMapper;
using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.ResponseDTO;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using GabrovoUltraWebApp.Server.CustomActionFilters;
using Microsoft.AspNetCore.Mvc;

namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        private readonly IRaceService raceService;
        private readonly IMapper mapper;
        private readonly ILogger<RaceController> logger;

        public RaceController(IRaceService _raceService, IMapper _mapper, ILogger<RaceController> _logger)
        {
            raceService = _raceService;
            mapper = _mapper;
            logger = _logger;
        }
        // GET: api/Race
        // Get all races
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            var races = await raceService.GetAllAsync();
            return Ok(mapper.Map<List<RaceDTO>>(races));
        }

        //GET: api/Race/id=5
        //Get race by id
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var race = await raceService.GetByIdAsync(id);
            if (race == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<RaceDTO>(race));
        }

        //POST: api/Race/
        //Create a new race
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ValidateDate]
        [ValidateModelState]
        public async Task<IActionResult> Create([FromBody] CreateOrUpdateRaceRequestDTO raceRequestDTO)
        {

            var raceToCreate = mapper.Map<Race>(raceRequestDTO);

            await raceService.CreateAsync(raceToCreate);

            var raceDTO = mapper.Map<RaceDTO>(raceToCreate);

            return CreatedAtAction(nameof(GetById), new { id = raceDTO.Id }, raceDTO);
        }

        //PUT: api/race/id=5
        //Update Race by id
        [HttpPut]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ValidateDate]
        [ValidateModelState]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] CreateOrUpdateRaceRequestDTO raceRequestDTO)
        {
            var raceToUpdate = mapper.Map<Race>(raceRequestDTO);

            var updatedRace = await raceService.UpdateAsync(id, raceToUpdate);

            if (updatedRace == null)
            {
                return BadRequest(ModelState);
            }

            return Ok(mapper.Map<RaceDTO>(updatedRace));

        }
        //DELETE: api/Race/id=5
        //Delete race by id
        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deletedRace = await raceService.DeleteAsync(id);
            if (deletedRace == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<RaceDTO>(deletedRace));
        }
        [HttpGet]
        [Route("current")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetCurrentRace()
        {
            var currentRace = await raceService.GetCurrentRaceAsync();
            if (currentRace == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<RaceDTO>(currentRace));
        }
        [HttpGet]
        [Route("{raceId:int}/distances")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAllRaceDistances([FromRoute] int raceId)
        {
            var distances = await raceService.GetAllRaceDistanceAsync(raceId);
            if (distances == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<DistanceDTO>>(distances));
        }
    }
}
