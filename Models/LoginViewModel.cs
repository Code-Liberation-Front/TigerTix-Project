using System.ComponentModel.DataAnnotations;

namespace TigerTix.Web.Models
{
	public class LoginViewModel
	{
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
		public bool Authentication()
		{
			if (Username == "testing" && Password == "Beans123")
			{
				return true;
			}
			return false;
		}
	}
}
