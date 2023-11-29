using Infrastructure.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebCrudAPI.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        
        public UserController()
        {
            _userService = new UserService();
        }

        [HttpGet("allUsers")]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpGet("id")]
        public IActionResult GetUserById([FromQuery] int id)
        {
            return Ok(_userService.GetUserById(id));
        }

        [HttpPost]
        public IActionResult AddUser(UserModel user)
        {
            return Ok(_userService.AddUser(user));
        }

        [HttpPut()]
        public IActionResult UpdateUser(UserModel user)
        {
            _userService.UpdateUser(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userService.DeleteUser(id);
            return NoContent();
        }
    }
}
