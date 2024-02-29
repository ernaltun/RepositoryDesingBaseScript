using Microsoft.AspNetCore.Mvc;
using RepositoryDesingScript.Models;
using RepositoryDesingScript.Repository;

namespace RepositoryDesingScript.Controllers
{
    public class UserController : Controller
    {
        private readonly UserRepository userRepository;
        public UserController(UserRepository repository)
        {
            userRepository = repository;
        }
        public IActionResult GetAllUsers()
        {
            var users = userRepository.GetAll().ToArray();
            return View(users);
        }
        [HttpGet]
		public ActionResult AddUser()
		{
			return View();
		}
        [HttpPost]
		public ActionResult AddUser(User user)
        {
            userRepository.Insert(user);
            return View();
        }
    }
}
