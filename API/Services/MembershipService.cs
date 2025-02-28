using GymManagement.API.Models;

namespace GymManagement.API.Services
{
    // Services/MembershipService.cs
    public class MembershipService : IMembershipService
    {
        private readonly AppDbContext _context;
        public MembershipService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Membership> AddMembership(Membership membership)
        {
            _context.Memberships.Add(membership);
            await _context.SaveChangesAsync();
            return membership;
        }
    }
}
