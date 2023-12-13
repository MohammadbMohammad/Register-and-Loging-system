using Microsoft.AspNetCore.Mvc;
using Register.Data;
using System.Linq;
using Login.Models;
using Login.Properties;

namespace Login.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserContext _userContext;

        public LoginController(UserContext userContext)
        {
            _userContext = userContext;
        }
        [HttpPost]
        public IActionResult Login(string Email, String PhoneNumber, string password)
        {
            // Find the user by email or phone number
            var user = _userContext.Users.FirstOrDefault(u => u.Email == Email || u.PhoneNumber == PhoneNumber);

            if (user == null)
            {
                return NotFound("User not found!");
            }

            // Validate the password
            if (user.Password != password)
            {
                return Unauthorized("Invalid password!");
            }

            // Successful login
            return Ok(new LoginResponse { Success = "Yes; You Logged IN " });
        }
    }


    }