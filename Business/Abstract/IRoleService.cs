using Business.Utilities.ResultType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoleService
    {
        Result<List<Role>> GetRoles();
        Result<Role> AddRole(Role role);
        Result<Role> UpdateRole(int roleId, Role role);
        Result<Role> DeleteRole(int roleId);
        Result<Role> HardDeleteRole(int roleId);

        Result<Role> GetRoleById(int roleId);
    }
}
