using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Core.Services
{
    public class HeroSectionService : IHeroSectionService
    {
        private readonly IRepository repository;
        public HeroSectionService(IRepository _repository) 
        {
            repository = _repository;
        }

        public async Task<HeroSection> CreateHeroSectionAsync(HeroSection heroSection)
        {
            await repository.AddAsync<HeroSection>(heroSection);
            await repository.SaveChangesAsync();
            return heroSection;
        }
            

        public async Task<HeroSection?> DeleteHeroSectionAsync(int id)
        {
            var sectionToDelete = await repository.DeleteAsync<HeroSection>(id);
            if (sectionToDelete == null)
            {
                return null;
            }
            await repository.SaveChangesAsync();
            return sectionToDelete;
        }
            

        public async Task<ICollection<HeroSection>> GetAllHeroSectionsAsyncReadOnly()
        =>await repository.AllReadonly<HeroSection>().ToListAsync();

        public async Task<HeroSection?> GetHeroSectionByIdAsync(int id)
       => await repository.GetByIdAsync<HeroSection>(id);

        public async Task<HeroSection?> UpdateHeroSectionAsync(int id, HeroSection heroSection)
        {
            var heroSectionToUpdate = await repository.GetByIdAsync<HeroSection>(id);
            if (heroSectionToUpdate == null)
            {
                return null;
            }
            heroSectionToUpdate.Name = heroSection.Name;
            heroSectionToUpdate.Description = heroSection.Description;
            heroSectionToUpdate.ImageUrl = heroSection.ImageUrl;
            repository.Update(heroSectionToUpdate);
            await repository.SaveChangesAsync();
            return heroSectionToUpdate;
            
        }
    }
}
