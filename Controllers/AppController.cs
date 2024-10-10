using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{

    public class AppController : Controller
    {
		public IActionResult Index()
		{
			return View("LoginScreen");
		}

		[HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (model.Username == "testing" && model.Password == "Beans123") {
                return RedirectToAction("TicketView");
            }
            return View("LoginScreen");
        }

        [HttpGet("/dashboard")]
        public IActionResult TicketView()
        {
            return View("TicketHomePage");
        }
    }
}
