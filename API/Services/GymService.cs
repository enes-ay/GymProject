using GymManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GymManagement.API.Services
{
    // Services/GymService.cs
    public class GymService : IGymService
    {
        private readonly AppDbContext _context;
        public GymService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Gym>> GetAllGyms()
        {
            return await _context.Gyms.ToListAsync();
        }

        public async Task<Gym> AddGym(Gym gym)
        {
            _context.Gyms.Add(gym);
            await _context.SaveChangesAsync();
            return gym;
        }
    }
}
