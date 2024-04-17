using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GabrovoUltraWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService adminService;

        public AdminController(IAdminService _adminService)
        {
            adminService = _adminService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize(Roles="Writer")]
        public async Task<IActionResult> GetAllUsers([FromQuery] string? filterOn,
                       [FromQuery] string? filterQuery, [FromQuery] string? sortBy, [FromQuery] bool? isAscending,
                                  [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 1000)
        {
            var users = await adminService.GetAllUsers();
            return Ok(users);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("Delete")]
        [Authorize(Roles="Writer")]
        public async Task<IActionResult> DeleteUser([FromQuery] string id)
        {
            var user = await adminService.DeleteUser(id);
            if (user is null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("Update/{userId}")]
        [Authorize(Roles="Writer")]
        public async Task<IActionResult> UpdateUser([FromRoute] string userId ,[FromBody] AdminUpdateRequestDTO user)
        {
            var updatedUser = await adminService.UpdateUser(userId,user);
            if (updatedUser is null)
            {
                return NotFound();
            }
            return Ok(updatedUser);
        }
    }
}
