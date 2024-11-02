using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{

    public class AppController : Controller
    {
		public IActionResult Index()
		{
			return View();
		}
        
        public IActionResult Login()
        {
            return View();
        }
        
		[HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "testing" && model.UserPassword == "Beans123") {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult BuyTickets()
        {
            return View();
        }

        public IActionResult CreateUser()
        {
            return View();
        }
        
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
