using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TigerTix.Web.Models
{
    // Define a class with user attributes
    public class TicketModel
    {
	    // Set Ticket id in the db
	    [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	    public int TicketID { get; set; }
		
        [Required]
        // Set the Ticket Title
        public string TicketTitle { get; set; }
        
        [Required]
        // Set the Ticket Date
        public string TicketDate { get; set; }
        
        [Required]
        // Set the Ticket Location
        public string TicketLocation { get; set; }
        
        [Required]
        // Sets the Location for the Ticket Image
        public string TicketPath { get; set; }
    }
}