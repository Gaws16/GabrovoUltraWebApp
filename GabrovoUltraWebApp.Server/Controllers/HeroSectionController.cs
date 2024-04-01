using AutoMapper;
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
    public class HeroSectionController : ControllerBase
    {
        
        private readonly IHeroSectionService heroSectionService;
        private readonly IMapper mapper;

        
        public HeroSectionController(IHeroSectionService service, IMapper _mapper)
        {
            heroSectionService = service;
            mapper = _mapper;
        }


        // GET: api/HeroSection/All
        //Get all hero sections
        [HttpGet("All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Produces("application/json")]
        public async Task<IActionResult> All()
        {
            var sections = await heroSectionService.GetAllHeroSectionsAsyncReadOnly();

            return Ok(mapper.Map<List<HeroSectionDTO>>(sections));
        }

        // GET: api/HeroSection/id=5
        //Get hero section by id
        [HttpGet]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var section = await heroSectionService.GetHeroSectionByIdAsync(id);
            if (section == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<HeroSectionDTO>(section));
        }

        // POST: api/HeroSection
        //Create a new hero section
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ValidateModelState]
        public async Task<IActionResult> CreateHeroSection([FromBody] CreateHeroSectionRequestDTO heroSectionDTO)
        {
            
            var heroSection = mapper.Map<HeroSection>(heroSectionDTO);
            var createdHeroSection = await heroSectionService.CreateHeroSectionAsync(heroSection);
            var createdHeroSectionDTO = mapper.Map<HeroSectionDTO>(createdHeroSection);
            return CreatedAtAction(nameof(GetById), new { id = createdHeroSection.Id }, createdHeroSectionDTO);
        }

        // PUT: api/HeroSection/id=5
        //Update a hero section
        [HttpPut]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ValidateModelState]
        public async Task<IActionResult> UpdateHeroSection([FromRoute] int id, [FromBody] UpdateHeroSectionRequestDTO heroSectionDTO)
        {
            var heroSection = mapper.Map<HeroSection>(heroSectionDTO);
            var updatedHeroSection = await heroSectionService.UpdateHeroSectionAsync(id, heroSection);
            if (updatedHeroSection == null)
            {
                return NotFound();
            }
            var udpatedHeroSectionDTO = mapper.Map<HeroSectionDTO>(updatedHeroSection);
            return Ok(udpatedHeroSectionDTO);
        }

        // DELETE: api/HeroSection/id=5
        //Delete a hero section
        [HttpDelete]
        [Route("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteHeroSection([FromRoute] int id)
        {
            var deletedHeroSection = await heroSectionService.DeleteHeroSectionAsync(id);
            if (deletedHeroSection == null)
            {
                return NotFound();
            }
            await heroSectionService.DeleteHeroSectionAsync(id);
            return Ok(mapper.Map<HeroSectionDTO>(deletedHeroSection));
        }
    }
}
