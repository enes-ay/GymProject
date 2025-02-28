using GymManagement.API.Models;

namespace GymManagement.API.Services
{
    // Services/IUserService.cs
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<User> Register(User user);
    }
}
