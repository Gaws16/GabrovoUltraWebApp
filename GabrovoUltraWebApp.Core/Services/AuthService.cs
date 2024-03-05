using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace GabrovoUltraWebApp.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration config;

        public AuthService(UserManager<IdentityUser> userManager, IConfiguration config)
        {
            this.userManager = userManager;
            this.config = config;
        }

        public string GenerateTokenString(LoginRequestModel user)
        {
            IEnumerable<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Username),
                new Claim(ClaimTypes.Role, "Admin")

            };
            //Setting up encryption key
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("Jwt:Key").Value));
                    SigningCredentials signingInCredential = new SigningCredentials(securityKey
               , SecurityAlgorithms.HmacSha512Signature
               );
            var token = new JwtSecurityToken(
                claims:claims,
                expires:DateTime.Now.AddMinutes(60),
                issuer:config.GetSection("Jwt:Issuer").Value,
                audience:config.GetSection("Jwt:Audience").Value,
                signingCredentials:signingInCredential
                );
            
                
            string tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenString;
        }

        public async Task<bool> LoginUser(LoginRequestModel loginRequest)
        {
            var identityUser = await userManager.FindByEmailAsync(loginRequest.Username);
         if(identityUser is null)
            {
                return false;
            }
         var result = await userManager.CheckPasswordAsync(identityUser, loginRequest.Password);
            return result;
        }

        public async Task<bool> RegisterUser(LoginRequestModel loginRequest)
        {
            var user = new IdentityUser
            {
                UserName = loginRequest.Username,
                Email = loginRequest.Username
            };
            var result = await userManager.CreateAsync(user, loginRequest.Password);

            return result.Succeeded;
        }

    }
}
