using JWTAuthentication.Models;

namespace JWTAuthentication.Services.AuthService
{
    public interface IAuthRepository
    {
        Task<ServiceResponce<int>> Register(User user, string password);
        Task<ServiceResponce<string>> Login(string email, string password);
        Task<bool> UserExists(string email);
    }
}
