using GabrovoUltraWebApp.Server.Models;

namespace GabrovoUltraWebApp.Server.Services.Contracts
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(LoginRequestModel loginRequest);
    }
}