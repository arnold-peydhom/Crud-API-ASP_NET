using Domain.Entities;

namespace Domain.Repositories
{
    public class UserRepository
    {
        public readonly CrudApiContext _context;

        public UserRepository()
        {
            _context = new CrudApiContext();
        }

        public List<User> GetAllUsers()
        {
            return _context.User.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.User.FirstOrDefault(x => x.UserId == id);
        }

        public bool AddUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteUser(int id)
        {
            var getUserById = GetUserById(id);
            _context.Remove(getUserById);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
            return true;
        }
    }
}
