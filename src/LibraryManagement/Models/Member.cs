using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
	public class Member
	{
		[Key]
		public int MembershipNumber { get; set; }
		public string Name { get; set; }
		public string JoinDate { get; set; }

	}
}
