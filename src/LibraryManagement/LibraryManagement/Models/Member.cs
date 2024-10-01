using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
	public class Member
	{
		[Key]
		public int MembershipNumber { get; set; }
		public string Name { get; set; }
		public string JoinDate { get; set; }
		public bool IsSubscribed { get; set; }
		public string Gender { get; set; }
		public string SelectedCountry { get; set; }
		public TimeSpan PreferTime { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Level { get; set; }
		public int Age { get; set; }

	}
}
