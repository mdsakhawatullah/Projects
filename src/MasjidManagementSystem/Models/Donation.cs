using System.ComponentModel.DataAnnotations;

namespace MasjidManagementSystem.Models
{
	public class Donation
	{
		[Key]
		public int Id { get; set; }
		public string DonarName { get; set; }
		public int Amount { get; set; }
		public string DonationDate { get; set; }
		public bool IsSubscribed { get; set; }
		public string Gender { get; set; }
		public string SelectedCountry { get; set; }
		public TimeSpan PreferTime { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Level { get; set; }
		public int Age { get; set; }
	}
}
