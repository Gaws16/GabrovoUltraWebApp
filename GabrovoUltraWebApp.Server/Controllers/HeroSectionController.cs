using GabrovoUltraWebApp.Core.Services;
using GabrovoUltraWebApp.Core.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroSectionController : ControllerBase
    {
        
        private readonly IHeroSectionService heroSectionService;

        
        public HeroSectionController(IHeroSectionService service)
        {
            heroSectionService = service;
        }

        [HttpGet("All")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<IActionResult> GetAllHeroSections()
        {
            var sections = JsonConvert.SerializeObject
                ( await heroSectionService.GetAllHeroSectionsAsyncReadOnly()
                ,Formatting.Indented);



            return Ok(sections);
        }
    }
}
