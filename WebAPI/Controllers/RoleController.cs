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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        // GET: api/<RoleController>
        [HttpGet("getroles")]
        public IActionResult GetRoles()
        {
            var result = _roleService.GetRoles();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }


        [HttpGet("getrolebyid/{roleId}")]
        public IActionResult GetRoleById(int roleId)
        {
            var result = _roleService.GetRoleById(roleId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            else
            {
                return NotFound(result.Message);
            }
        }


        [HttpPost("addrole")]
        public IActionResult AddRole(Role role)
        {
            var result = _roleService.AddRole(role);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }
        }


        [HttpPut("updaterole/{id}")]
        public IActionResult UpdateRole(int id, Role role)
        {
            var result = _roleService.UpdateRole(id, role);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }
        [HttpPatch("deleterole/{id}")]
        public IActionResult DeleteRole(int id)
        {
            var result = _roleService.DeleteRole(id);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            else
            {
                return BadRequest(result.Message);
            }

        }

        [HttpDelete("harddeleterole/{id}")]
        public IActionResult HardDeleteRole(int id)
        {
            var result = _roleService.HardDeleteRole(id);
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
