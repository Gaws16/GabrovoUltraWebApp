using GabrovoUltraWebApp.Server.Models;
using GabrovoUltraWebApp.Server.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GabrovoUltraWebApp.Server.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<IdentityUser> userManager;

        public AuthService(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
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
