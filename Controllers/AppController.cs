using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{
    // Controller class
    public class AppController : Controller
    {
        // Return the Index view
		public IActionResult Index()
		{
			return View();
		}
        // Return the login view
        public IActionResult Login()
        {
            return View();
        }
        // Redirects user to Index after login using the login model
		[HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "testing" && model.UserPassword == "Beans123") {
                return RedirectToAction("BuyTickets");
            }
            return View();
        }
        // Returns the BuyTickets view
        public IActionResult BuyTickets()
        {
            return View();
        }
        // Returns the CreateUser view
        public IActionResult CreateUser()
        {
            return View("CreateUser");
        }
        // Returns the Contact view
        public IActionResult Contact()
        {
            return View();
        }
        // Returns the Cart view
        public IActionResult Cart()
        {
            return View();
        }
        // Handles User creation by taking input from user and adding to the db
        [HttpPost]
        public IActionResult CreateUser(LoginModel model)
        {
            model.UserJoinDate = DateTime.UtcNow.Date.ToString("yyyy-MM-dd");
            using (var db = new DbModel())
            {
                db.Add(model);
                db.SaveChanges();
            }
            return View();
        }
    }
}
