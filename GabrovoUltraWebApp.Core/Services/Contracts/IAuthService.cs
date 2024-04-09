using GabrovoUltraWebApp.Infrastructure.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(RegisterRequestDTO loginRequest);
        Task<bool> LoginUser(LoginRequestDTO loginRequest);
        Task<TokenResponseDTO> GenerateToken(LoginRequestDTO user);
        Task<string?> GetUserIdAsync(string username);
    }
}