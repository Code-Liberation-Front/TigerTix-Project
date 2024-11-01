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

		[HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Username == "testing" && model.Password == "Beans123") {
                return RedirectToAction("Index");
            }
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult BuyTickets()
        {
            return View();
        }
    }
}
