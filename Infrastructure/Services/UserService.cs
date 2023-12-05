using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Models;

namespace Infrastructure.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
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
            _userRepository.AddUser(userConvert);
            return true;
        }

        public bool DeleteUser(int id)
        {
            var getUserById = _userRepository.GetUserById(id);
            if (getUserById is null)
            {
                return false;
            }
            _userRepository.DeleteUser(id);
            return true;
        }

        public bool UpdateUser(UserModel user)
        {
            var getUserById = GetUserById(user.UserId);
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
            _userRepository.UpdateUser(userConvert);
            return true;
        }
    }
}
