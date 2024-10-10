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

		[HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
			return View("TicketHomePage");
        }
    }
}
