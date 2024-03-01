using GabrovoUltraWebApp.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace GabrovoUltraWebApp.Server.Services.Contracts
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(LoginRequestModel loginRequest);
        Task<bool> LoginUser(LoginRequestModel loginRequest);
        string GenerateTokenString(LoginRequestModel user);
    }
}