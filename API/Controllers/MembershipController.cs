using GymManagement.API.Models;
using GymManagement.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.API.Controllers
{

    // Controllers/MembershipController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class MembershipController : ControllerBase
    {
        private readonly IMembershipService _membershipService;
        public MembershipController(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMembership(Membership membership)
        {
            var result = await _membershipService.AddMembership(membership);
            return Ok(result);
        }
    }
}
