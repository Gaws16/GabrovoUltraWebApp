﻿using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;

namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IRunnerService
    {
        Task<List<RunnerDTO>> GetAllAsync(string? filterOn = null, string? filterQuery = null,
                                        string? sortBy = null, bool? isAscending = true,
                                        int pageNumber = 1, int pageSize = 1000);

        Task<ApplicationUser?> GetByIdAsync(int id);

        Task<int> GetCountAsync();

        Task<ApplicationUser?> CreateAsync(ApplicationUser runner);

        Task<ApplicationUser?> UpdateAsync(string id, ApplicationUser runner);

        Task<ApplicationUser?> DeleteAsync(int id);
    }
}
