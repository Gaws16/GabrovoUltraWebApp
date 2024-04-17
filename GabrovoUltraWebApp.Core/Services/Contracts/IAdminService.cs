using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IAdminService
    {
        Task<List<DisplayUsersDTO>> GetAllUsers(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending, int pageNumber = 1, int pageSize = 1000);
        Task<ApplicationUser> DeleteUser(string id);
    }
}
