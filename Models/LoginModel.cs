using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TigerTix.Web.Models
{
	// Define a class with user attributes
	public class LoginModel
	{
		// Set user id in the db
		[Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserID { get; set; }
		
		[Required(ErrorMessage = "Username is required")]
		// Set the username
		public string Username { get; set; }
		
		[Required(ErrorMessage = "Password is required")]
		// Set the password
		public string UserPassword { get; set; }
		
		[Required(ErrorMessage = "Email is required")]
		[RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Please enter a valid email address.")]
		// Set the email
		public string UserEmail { get; set; }
		
		[Required(ErrorMessage = "CUID is required")]
		// Set the cuid
		public string UserCUID { get ; set; }
		
		[Required(ErrorMessage = "Date of Birth is Required")]
		// Set the dob
		public DateTime UserDOB { get; set; }
		// Set the join date
		public DateTime UserJoinDate{ get; set; }
	}
}
