using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TigerTix.Web.Models
{
	public class LoginModel
	{
		[Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserId { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string UserPassword { get; set; }
		[Required]
		public string UserEmail { get; set; }
		[Required]
		public string UserCUID { get ; set; }
		[Required]
		public string UserDOB { get; set; }
		public string UserJoinDate{ get; set; }
	}
}
