using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Models.Data
{
    public class GabrovoUltraContext: IdentityDbContext<IdentityUser>
    {
        public GabrovoUltraContext(DbContextOptions<GabrovoUltraContext> options) : base(options) 
        {
            
        }
    }
}
