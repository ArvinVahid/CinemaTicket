using CinemaTicket.Business.Dto;
using CinemaTicket.Business.Entities;
using CinemaTicket.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CinemaTicket.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<User>> GetAllUsers()
        {
            return _userService.GetAll();
        }

        [HttpGet("GetById")]
        public ActionResult<User> GetUserById(int id)
        {
            return _userService.GetEntityById(id);
        }

        [HttpPost("Insert")]
        public IActionResult InsertUser(UserInsertDto dto)
        {
            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Password = dto.Password,
                RegisterDate = DateTime.Now,
            };

            _userService.Insert(user);
            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult UpdateUser(User user)
        {
            if (_userService.IsUserExists(user.Id))
            {
                _userService.Update(user);
                return Ok();
            }
            return NoContent();
        }

        [HttpDelete("Delete")]
        public IActionResult DeleteUser(int id)
        {
            if (_userService.IsUserExists(id))
            {
                _userService.Remove(id);
                return Ok();
            }
            return NoContent();
        }

    }
}
