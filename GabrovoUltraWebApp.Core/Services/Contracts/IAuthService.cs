using GabrovoUltraWebApp.Infrastructure.Models;
namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(LoginRequestModel loginRequest);
        Task<bool> LoginUser(LoginRequestModel loginRequest);
        string GenerateTokenString(LoginRequestModel user);
    }
}