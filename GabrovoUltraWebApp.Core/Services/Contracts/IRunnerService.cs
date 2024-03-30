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
        Task<List<Runner>> GetAllAsync(string? filterOn = null, string? filterQuery = null,
                                        string? sortBy = null, bool? isAscending = true,
                                        int pageNumber = 1, int pageSize = 1000);

        Task<Runner?> GetByIdAsync(int id);

        Task<Runner?> CreateAsync(Runner runner);

        Task<Runner?> UpdateAsync(int id, Runner runner);

        Task<Runner?> DeleteAsync(int id);
    }
}
