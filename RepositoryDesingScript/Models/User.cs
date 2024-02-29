using System.ComponentModel.DataAnnotations;

namespace RepositoryDesingScript.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Password { get; set; }
        public string Mail { get; set; }
    }
}
