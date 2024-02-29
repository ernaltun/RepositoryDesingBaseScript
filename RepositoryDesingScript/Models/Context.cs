using Microsoft.EntityFrameworkCore;

namespace RepositoryDesingScript.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options): base(options) 
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
