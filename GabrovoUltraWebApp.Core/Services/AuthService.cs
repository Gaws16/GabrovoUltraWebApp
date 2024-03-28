using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
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

        public async Task<string> GenerateTokenString(LoginRequestDTO loginRequestDTO)
        {
            var user = await userManager.FindByEmailAsync(loginRequestDTO.Username);
            IEnumerable<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.UserName),
            };
            var roles = await userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Append(new Claim(ClaimTypes.Role, role));
            }
                

            //Setting up encryption key
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("Jwt:Key").Value));
                    SigningCredentials signingInCredential = new SigningCredentials(securityKey
               , SecurityAlgorithms.HmacSha512Signature
               );
            var token = new JwtSecurityToken(
                claims:claims,
                expires:DateTime.Now.AddMinutes(15),
                issuer:config.GetSection("Jwt:Issuer").Value,
                audience:config.GetSection("Jwt:Audience").Value,
                signingCredentials:signingInCredential
                );
            
                
            string tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenString;
        }

        public async Task<bool> LoginUser(LoginRequestDTO loginRequest)
        {
            var identityUser = await userManager.FindByEmailAsync(loginRequest.Username);
         if(identityUser is null)
            {
                return false;
            }
         var result = await userManager.CheckPasswordAsync(identityUser, loginRequest.Password);
            return result;
        }

        public async Task<bool> RegisterUser(RegisterRequestDTO registerRequest)
        {
            var user = new IdentityUser
            {
                UserName = registerRequest.Username,
                Email = registerRequest.Username
            };
            var result = await userManager.CreateAsync(user, registerRequest.Password);

            if (registerRequest.Roles != null && registerRequest.Roles.Any() && result.Succeeded)
            {
                result =  await userManager.AddToRolesAsync(user, registerRequest.Roles);
            }
               

            return result.Succeeded;
        }

        public async Task<string?> GetUserIdAsync(string username)
        {
            var currentUser = await userManager.FindByEmailAsync(username);
            return currentUser?.Id;
        }
    }
}
