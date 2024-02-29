using RepositoryDesingScript.Interface;
using RepositoryDesingScript.Models;

namespace RepositoryDesingScript.Repository
{
    public class UserRepository : IUserInterface
    {
        private readonly Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if(user != null)
            {
                _context.Users.Remove(user);
            }
        }

        public IEnumerable<User> GetAll()
        {
            var users = _context.Users;
            return users;
        }

        public User GetById(int id)
        {
            var user = _context.Users.Find(id);
            return user;
        }

        public void Insert(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
        }
    }
}
