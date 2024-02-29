using RepositoryDesingScript.Models;

namespace RepositoryDesingScript.Interface
{
    public interface IUserInterface
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Insert(User user);
        void Update(User user);
        void Delete(int id);
        void Save();

    }
}
