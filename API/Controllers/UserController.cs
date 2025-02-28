using Microsoft.AspNetCore.Mvc;
using GymManagement.API.Services;
using GymManagement.API.Models;

namespace GymManagement.API.Controllers
{
    // Controllers/UserController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User user)
        {
            var result = await _userService.Register(user);
            return Ok(result);
        }
    }
}
