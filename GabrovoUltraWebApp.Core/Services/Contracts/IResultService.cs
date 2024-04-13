using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IResultService
    {
        Task<List<ResultDTO?>> GetAllAsync(int raceId, int distanceId,string? filterOn = null, string? filterQuery = null,
                                        string? sortBy = null, bool? isAscending = true,
                                        int pageNumber = 1, int pageSize = 1000);

        Task<Result?> GetByIdAsync(int id);

        Task<Result?> CreateAsync(Result runner);

        Task<Result?> UpdateAsync(int id, Result runner);

        Task<Result?> DeleteAsync(int id);
    }
}
