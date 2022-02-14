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
            bool IsRoleNameExist = _roleDal.Any(u => u.RoleName == role.RoleName);
            if (IsRoleNameExist) { return new Result<Role>(false,Messages.RoleAlreadyExist); }
            else
            {
                _roleDal.Add(role);
                return new Result<Role>(true,Messages.RoleAdded);
            }
            

        }

        public Result<Role> DeleteRole(int roleId)
        {
            var IsRoleExist = _roleDal.Get(u => u.Id == roleId);
            if (IsRoleExist != null)
            {
                IsRoleExist.IsDeleted = true;
                IsRoleExist.ModifiedDate = DateTime.Now;
                _roleDal.Update(IsRoleExist);
                return new Result<Role>(true,Messages.RoleDeleted);
            }
            else{
                return new Result<Role>(false, Messages.RoleNotFound);
            }
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
            var IsRoleExist = _roleDal.Get(u => u.Id == roleId);
            if (IsRoleExist != null)
            {
 
                _roleDal.Delete(IsRoleExist);
                return new Result<Role>(true, Messages.RoleDeleted);
            }
            else
            {
                return new Result<Role>(false, Messages.RoleNotFound);
            }
        }

        public Result<Role> UpdateRole(int roleId, Role role)
        {
            var IsRoleExist = _roleDal.Get(u => u.Id == roleId);
            if (IsRoleExist != null)
            {
                IsRoleExist.RoleName = role.RoleName;
                IsRoleExist.ModifiedDate = DateTime.Now;
                IsRoleExist.ModifiedDate = DateTime.Now;
                _roleDal.Update(IsRoleExist);
                return new Result<Role>(true, Messages.RoleUpdated);
            }
            else
            {
                return new Result<Role>(false, Messages.RoleNotFound);
            }
        }
    }
}
