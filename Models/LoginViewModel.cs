using System.ComponentModel.DataAnnotations;

namespace TigerTix.Web.Models
{
	public class LoginViewModel
	{
		[Key] public int UserId { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
	}
}
