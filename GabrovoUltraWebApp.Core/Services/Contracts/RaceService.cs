using GabrovoUltraWebApp.Infrastructure.Data;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public class RaceService : IRaceService
    {
        private readonly GabrovoUltraContext context;
        public RaceService(GabrovoUltraContext _context)
        {
            context = _context;
        }
        public async Task<List<Race>> GetAllAsync()
        {
           return await context.Races
                .AsNoTracking()
                .ToListAsync();
                
                
        }
               
                
    }
}
