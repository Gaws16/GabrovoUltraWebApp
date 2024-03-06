using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Core.Services
{
    public class HeroSectionService : IHeroSectionService
    {
        private readonly GabrovoUltraContext context;
        public HeroSectionService(GabrovoUltraContext context) 
        {
            this.context = context;
        }
        public async Task<ICollection<HeroSection>> GetAllHeroSectionsAsyncReadOnly()
        =>await context.HeroSections
            .ToListAsync();
            
    }
}
