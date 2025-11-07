using Microsoft.AspNetCore.Mvc;
using UserManagementWebAPI.Service;
using UserManagementWebAPI.Model;
using System.Reflection.Metadata.Ecma335;

namespace UserManagementWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }
        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            _userService.AddUser(user);
            return Ok(user);
        }
        [HttpGet("byid/{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)

                return NotFound();

            return Ok(user);


        }
        [HttpGet("byemail/{email}")]
        public IActionResult GetByEmail(string email)
        {
            var user = _userService.GetUserByEmail(email);
            if (user == null)

                return NotFound();

            return Ok(user);
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] User login)
        {
            var result = _userService.Login(login.Email, login.Password);
            if (!result) return Unauthorized();
            else return Ok("Login successfully!");

        }
    }
}
