using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{

    public class AppController : Controller
    {
		public IActionResult Index()
		{
			return View("TicketHomePage");
		}

		[HttpPost("/login")]
        public IActionResult LoginView(LoginViewModel model)
        {
            if (model.Username == "testing" && model.Password == "Beans123") {
                return RedirectToAction("Index");
            }
            return RedirectToAction("LoginView");
        }

        [HttpGet("/login")]
        public IActionResult LoginView()
        {
            return View("LoginScreen");
        }
    }
}
