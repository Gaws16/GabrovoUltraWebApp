﻿using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
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
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration config;

        public AuthService(UserManager<ApplicationUser> userManager, IConfiguration config)
        {
            this.userManager = userManager;
            this.config = config;
        }

        public async Task<TokenResponseDTO> GenerateToken(LoginRequestDTO loginRequestDTO)
        {
            var user = await userManager.FindByEmailAsync(loginRequestDTO.Username);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
            };
            var roles = await userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
                

            //Setting up encryption key
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("Jwt:Key").Value));
                    SigningCredentials signingInCredential = new SigningCredentials(securityKey
               , SecurityAlgorithms.HmacSha512Signature
               );
            var token = new JwtSecurityToken(
                issuer:config.GetSection("Jwt:Issuer").Value,
                audience:config.GetSection("Jwt:Audience").Value,
                claims:claims,
                expires:DateTime.Now.AddMinutes(15),
                signingCredentials:signingInCredential
                );
            
            string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            var response = new TokenResponseDTO
            {
                JwtToken = tokenString,
                ExpirationTime = token.ValidTo,
                FirstName = user.FirstName,
                LastName = user.LastName,
                //Get the first role of the user (at this point we will have only one role per user)
                Role = roles.FirstOrDefault()
            };
            return response;
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
            
            var user = new ApplicationUser
            {
                UserName = registerRequest.Username,
                Email = registerRequest.Username,
                FirstName = registerRequest.FirstName,
                LastName = registerRequest.LastName,
                Team = registerRequest.Team,
                Age = registerRequest.Age,
                Gender = Enum.Parse<Gender>(registerRequest.Gender),
                Country = registerRequest.Country,
                City = registerRequest.City
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

        public async Task<ApplicationUser?> GetUserByIdAsync(string id)
        {
            return await userManager.FindByIdAsync(id);
        }
    }
}
