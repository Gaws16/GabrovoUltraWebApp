using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
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
        Task<List<DisplayUsersDTO>> GetAllUsers();
        Task<ApplicationUser> DeleteUser(string id);
        Task<AdminUpdateRequestDTO> UpdateUser(string userId, AdminUpdateRequestDTO user);
    }
}
