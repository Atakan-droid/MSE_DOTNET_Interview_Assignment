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
            bool IsUserExist = _userDal.Any(u => u.Mail == user.Mail);
            if (IsUserExist) { return new Result<User>(false, Messages.UserAlreadyExist); }
            else
            {
                _userDal.Add(user);
                return new Result<User>(true, Messages.UserAdded);
            }
        }

        public Result<User> DeleteUser(int userId)
        {
            var IsUserExist = _userDal.Get(u => u.Id == userId);
            if (IsUserExist != null)
            {
                IsUserExist.IsDeleted = true;
                IsUserExist.ModifiedDate = DateTime.Now;
                _userDal.Update(IsUserExist);
                return new Result<User>(true, Messages.UserDeleted);
            }
            else
            {
                return new Result<User>(false, Messages.UserNotFound);
            }
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
            return new Result<List<User>>(_userDal.GetAll(u=>u.IsDeleted==false),true,Messages.UsersGot);
        }

        public Result<List<User>> GetUsersByRole(int roleId)
        {
            var IsRoleExist = _userDal.GetAll(u => u.RoleID == roleId);
            if (IsRoleExist != null)
            {
               
                return new Result<List<User>>(IsRoleExist,true, Messages.UsersGot);
            }
            else
            {
                return new Result<List<User>>(false, Messages.RoleNotFound);
            }
        }

        public Result<User> HardDeleteUser(int userId)
        {
            var IsUserExist = _userDal.Get(u => u.Id == userId);
            if (IsUserExist != null)
            {
                
                _userDal.Delete(IsUserExist);
                return new Result<User>(true, Messages.UserDeleted);
            }
            else
            {
                return new Result<User>(false, Messages.UserNotFound);
            }
        }

        public Result<User> UpdateUser(int userId, User user)
        {
            var IsUserExist = _userDal.Get(u => u.Id == userId);
            if (IsUserExist != null)
            {
                IsUserExist.Mail = user.Mail;
                IsUserExist.Name = user.Name;
                IsUserExist.Password = user.Password;
                IsUserExist.Surname = user.Surname;
                IsUserExist.ModifiedDate = DateTime.Now;
                _userDal.Update(IsUserExist);
                return new Result<User>(true, Messages.UserUpdated);
            }
            else
            {
                return new Result<User>(false, Messages.UserNotFound);
            }
        }

     
    }
}
