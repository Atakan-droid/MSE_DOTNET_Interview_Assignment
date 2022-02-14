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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public Result<User> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Result<User> DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Result<User> GetUserById(int userId)
        {
            var result = _userDal.Get(u=>u.Id==userId);
            if (result != null)
            {
                return new Result<User>(result,true,Messages.UsersGot);
            }
            return new Result<User>(false,Messages.UserNotFound);
        }

        public Result<List<User>> GetUsers()
        {
            return new Result<List<User>>(_userDal.GetAll(),true,Messages.UsersGot);
        }

        public Result<List<User>> GetUsersByRole(int roleId)
        {
            throw new NotImplementedException();
        }

        public Result<User> HardDeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Result<User> UpdateUser(int userId, User user)
        {
            throw new NotImplementedException();
        }

     
    }
}
