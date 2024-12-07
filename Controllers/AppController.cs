using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;
using BC = BCrypt.Net.BCrypt;

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
        public IActionResult Login(LoginDBModel dbModel)
        {
            using (var db = new DbModel())
            {
                var verify = db.Users.SingleOrDefault(model => model.Username == dbModel.Username);
                if (verify == null) return View();
                if (BC.Verify(dbModel.UserPassword, verify.UserPassword)) return RedirectToAction("BuyTickets");
            }
            return View();
        }
        // Returns the BuyTickets view
        public IActionResult BuyTickets()
        {
            DbModel db = new DbModel();
            return View(db.Tickets.ToList());
        }
        // Returns the CreateUser view
        public IActionResult CreateUser()
        {
            return View();
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
        // Returns the Checkout view
        public IActionResult Checkout()
        {
            return View();
        }
        // Handles User creation by taking input from user and adding to the db
        [HttpPost]
        public IActionResult CreateUser(LoginDBModel dbModel)
        {
            dbModel.UserJoinDate = DateTime.UtcNow.Date;
            dbModel.UserIsAdmin = false;
            if (!ModelState.IsValid) return View(dbModel);
            dbModel.UserPassword = BC.HashPassword(dbModel.UserPassword);
            using (var db = new DbModel())
            {
                db.Add(dbModel);
                db.SaveChanges();
            }
            return RedirectToAction("Login");
        }

        public IActionResult Users()
        {
            DbModel db = new DbModel();
            return View(db.Users.ToList());
        }
    }
}
