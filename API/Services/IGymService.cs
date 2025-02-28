using GymManagement.API.Models;

namespace GymManagement.API.Services
{
    // Services/IGymService.cs
    public interface IGymService
    {
        Task<List<Gym>> GetAllGyms();
        Task<Gym> AddGym(Gym gym);
    }
}
