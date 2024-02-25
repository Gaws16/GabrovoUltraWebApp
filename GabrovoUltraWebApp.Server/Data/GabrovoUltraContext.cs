using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Server.Data
{
    public class GabrovoUltraContext: IdentityDbContext
    {
        public GabrovoUltraContext(DbContextOptions<GabrovoUltraContext> options) : base(options)
        {
            
        }
    }
}
