using Microsoft.AspNetCore.Mvc;
using TigerTix.Web.Models;

namespace TigerTix.Web.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult CreateTicket()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTicket(TicketViewModel ticket)
        {
            // Checks if the view has the information needed to proceed
            if (!ModelState.IsValid) return View(ticket);
            
            // Processes the uploaded image to ensure validity
            //List<string> validExtensions = new List<string>() {"*.jpg", "*.jpeg", "*.png"};
            string extension = Path.GetExtension(ticket.TicketImage.FileName);
            //if (!validExtensions.Contains(extension))
            //{
                //return $"Extension is not valid ({string.Join(',', validExtensions)})";
            //}
            //long size = ticket.TicketImage.Length;
            //if(size < 5 * 1024 * 1024)
                //return "Maximum file size is 5MB";
            string fileName = Guid.NewGuid().ToString() + extension;
            char separator = Path.DirectorySeparatorChar;
            Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{separator}upload{separator}"));
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{separator}upload{separator}");
            using FileStream stream = new FileStream(path + fileName, FileMode.Create);
            ticket.TicketImage.CopyTo(stream);

            TicketModel newTicket = new TicketModel();
            newTicket.TicketTitle = ticket.TicketTitle;
            newTicket.TicketDate = ticket.TicketDate;
            newTicket.TicketLocation = ticket.TicketLocation;
            newTicket.TicketPath = $"/upload/{fileName}";
            using (var db = new DbModel())
            {
                db.Add(newTicket);
                db.SaveChanges();
            }
            
            return RedirectToAction("BuyTickets", "App");
        }
    }
}