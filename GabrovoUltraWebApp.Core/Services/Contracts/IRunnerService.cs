using GabrovoUltraWebApp.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IRunnerService
    {
        Task<List<Runner>> GetAllAsync();

        Task<Runner?> GetByIdAsync(int id);

        Task<Runner?> CreateAsync(Runner runner);

        Task<Runner?> UpdateAsync(int id, Runner runner);

        Task<Runner?> DeleteAsync(int id);
    }
}
