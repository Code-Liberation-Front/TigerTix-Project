using System.ComponentModel.DataAnnotations;

namespace TigerTix.Web.Models
{
    // Define a class with user attributes
    public class TicketViewModel
    {
        [Required(ErrorMessage = "Title is required")]
        // Set the Ticket Title
        public string TicketTitle { get; set; }
        
        [Required(ErrorMessage = "Date is required")]
        // Set the Ticket Date
        public string TicketDate { get; set; }
        
        [Required(ErrorMessage = "Location is required")]
        // Set the Ticket Location
        public string TicketLocation { get; set; }
        
        [Required(ErrorMessage = "Image is required")]
        // Sets the Location for the Ticket Image
        public IFormFile TicketImage { get; set; }
    }
}