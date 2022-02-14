using Business.Utilities.ResultType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Result<User> AddUser(User user);
        Result<User> UpdateUser(int userId, User user);
        Result<User> DeleteUser(int userId);
        Result<User> HardDeleteUser(int userId);
        Result<List<User>> GetUsersByRole(int roleId);
        Result<List<User>> GetUsers();
        Result<User> GetUserById(int userId);
    }
}
