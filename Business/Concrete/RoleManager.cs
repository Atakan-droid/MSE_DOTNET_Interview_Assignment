using Business.Abstract;
using Business.Utilities.Messages;
using Business.Utilities.ResultType;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        public  IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public Result<Role> AddRole(Role role)
        {
            throw new NotImplementedException();
        }

        public Result<Role> DeleteRole(int roleId)
        {
            throw new NotImplementedException();
        }

        public Result<Role> GetRoleById(int roleId)
        {
            var result = _roleDal.Get(u => u.Id == roleId);
            if (result != null)
            {
                return new Result<Role>(result, true, Messages.RolesGot);
            }
            return new Result<Role>(false, Messages.RoleNotFound);
        }

    

        public Result<List<Role>> GetRoles()
        {
            return new Result<List<Role>>(_roleDal.GetAll(),true,Messages.RolesGot);
        }

        public Result<Role> HardDeleteRole(int roleId)
        {
            throw new NotImplementedException();
        }

        public Result<Role> UpdateRole(int roleId, Role role)
        {
            throw new NotImplementedException();
        }
    }
}
