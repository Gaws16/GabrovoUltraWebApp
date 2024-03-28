using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO
{
    public class RunnerDTO
    {
        public int Id { get; set; }

        public string UserId { get; set; } = null!;


        public virtual IdentityUser User { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int Age { get; set; }

        public string Gender { get; set; } = null!;


        public string? Team { get; set; }


        public string StartingNumber { get; set; } = null!;


    }
}
