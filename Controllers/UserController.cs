using dotnet_api_error_handling_example.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_api_error_handling_example.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] users = new[]
        {
            "user1", "user2",
        };

        public UserController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Post(UserDto user)

        {
            return Ok(users);
        }
    }
}