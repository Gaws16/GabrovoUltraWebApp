using GabrovoUltraWebApp.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IRegistrationService
    {
        Task<List<Registration>> GetAllAsync();

        Task<Registration?> GetByIdAsync(int id);

        Task<Registration?> CreateAsync(Distance distance, ApplicationUser user, Race race);

        Task<Registration?> UpdateAsync(int id, Registration Registration);

        Task<Registration?> DeleteAsync(int id);

        Task<string> GenerateStartingNumber(Distance distance);
    }
}
