using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO
{
    public class RunnerDTO
    {
        public int Id { get; set; }
        [JsonPropertyName("Име")]
        public string FirstName { get; set; } = null!;
        [JsonPropertyName("Фамилия")]
        public string LastName { get; set; } = null!;
        [JsonPropertyName("Възраст")]
        public int Age { get; set; }
        [JsonPropertyName("Пол")]
        public string Gender { get; set; }

        [JsonPropertyName("Отбор")]
        public string? Team { get; set; }

        [JsonPropertyName("Номер")]
        public string StartingNumber { get; set; } = null!;
        [JsonPropertyName("Дата на регистрация")]
        public string RegisteredOn { get; set;}
        [JsonPropertyName("Дистанция")]
        public string Distance { get; set; } = null!;


    }
}
