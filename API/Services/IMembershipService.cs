
using GymManagement.API.Models;

namespace GymManagement.API.Services
{
    // Services/IMembershipService.cs
    public interface IMembershipService
    {
        Task<Membership> AddMembership(Membership membership);
    }
}
