using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TigerTix.Web.Models
{
	// Define a class with user attributes
	public class LoginModel
	{
		// Set user id in the db
		[Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserId { get; set; }
		[Required]
		// Set the username
		public string Username { get; set; }
		[Required]
		// Set the password
		public string UserPassword { get; set; }
		[Required]
		// Set the email
		public string UserEmail { get; set; }
		[Required]
		// Set the cuid
		public string UserCUID { get ; set; }
		[Required]
		// Set the dob
		public string UserDOB { get; set; }
		// Set the join date
		public string UserJoinDate{ get; set; }
	}
}
