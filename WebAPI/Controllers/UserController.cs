using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
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
        [HttpGet("getusers")]
        public IActionResult GetUsers()
        {
            var result = _userService.GetUsers();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }
           
        }


        [HttpGet("getuserbyid/{userId}")]
        public IActionResult GetUserById(int userId)
        {
            var result = _userService.GetUserById(userId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return NotFound(result.Message);
            }
        }
        [HttpGet("getusersbyrole/{roleId}")]
        public IActionResult GetUserByRole(int roleId)
        {
            var result = _userService.GetUsersByRole(roleId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return NotFound(result.Message);
            }
        }


        [HttpPost("adduser")]
        public IActionResult AddUser(User user)
        {
            var result = _userService.AddUser(user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }

       
        [HttpPut("updateuser/{id}")]
        public IActionResult UpdateUser(int id,User user)
        {
            var result = _userService.UpdateUser(id,user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
        [HttpGet("deleteuser/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var result = _userService.DeleteUser(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpDelete("harddeleteuser/{id}")]
        public IActionResult HardDeleteUser(int id)
        {
            var result = _userService.HardDeleteUser(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }
    }
}
