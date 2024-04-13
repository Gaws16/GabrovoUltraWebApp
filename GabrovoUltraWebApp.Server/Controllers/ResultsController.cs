using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly IResultService resultService;

        public ResultsController(IResultService _resultService)
        {
            resultService = _resultService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Produces("application/json")]
        [Route("{raceId:int}, {distanceId:int}")]

        public async Task<ActionResult<List<Result>>> GetResults([FromRoute] int raceId, [FromRoute] int distanceId,string? filterOn = null,
            string? filterQuery = null, string? sortBy = null, bool? isAscending = true,
            int pageNumber = 1, int pageSize = 1000)
        {
            var results = await resultService.GetAllAsync(raceId,distanceId,filterOn, filterQuery, sortBy, isAscending, pageNumber, pageSize);
            return Ok(results);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Result>> GetResult(int id)
        {
            var result = await resultService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Result>> CreateResult(Result result)
        {
            var createdResult = await resultService.CreateAsync(result);
            if (createdResult == null)
            {
                return Conflict();
            }
            return CreatedAtAction(nameof(GetResult), new { id = createdResult.Id }, createdResult);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Result>> UpdateResult(int id, Result result)
        {
            var updatedResult = await resultService.UpdateAsync(id, result);
            if (updatedResult == null)
            {
                return NotFound();
            }
            return Ok(updatedResult);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Result>> DeleteResult(int id)
        {
            var deletedResult = await resultService.DeleteAsync(id);
            if (deletedResult == null)
            {
                return NotFound();
            }
            return Ok(deletedResult);
        }
    }
}
