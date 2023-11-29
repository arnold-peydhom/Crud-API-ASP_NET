using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Models;

namespace Infrastructure.Services
{
    public class UserService
    {
        private readonly UserRepository _userService;

        public UserService()
        {
            _userService = new UserRepository();
        }

        public List<User> GetAllUsers()
        {
            return _userService.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _userService.GetUserById(id);
        }

        public bool AddUser(UserModel user)
        {
            var getUserById = user.UserId;
            if (getUserById > 0)
            {
                return false;
            }
            var userConvert = new User()
            {
                UserId = user.UserId,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Profession = user.Profession,
            };
            _userService.AddUser(userConvert);
            return true;
        }

        public bool DeleteUser(int id)
        {
            var getUserById = _userService.GetUserById(id);
            if (getUserById is null)
            {
                return false;
            }
            _userService.DeleteUser(id);
            return true;
        }

        public bool UpdateUser(UserModel user)
        {
            var getUserById = _userService.GetUserById(user.UserId);
            if (getUserById is null)
            {
                return false;
            }
            var userConvert = new User()
            {
                UserId = user.UserId,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Profession = user.Profession,
            };
            _userService.UpdateUser(userConvert);
            return true;
        }
    }
}
