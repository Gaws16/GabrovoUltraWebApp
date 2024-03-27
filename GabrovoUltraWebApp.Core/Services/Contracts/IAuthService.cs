using GabrovoUltraWebApp.Infrastructure.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(RegisterRequestDTO loginRequest);
        Task<bool> LoginUser(LoginRequestDTO loginRequest);
        Task<string> GenerateTokenString(LoginRequestDTO user);
    }
}