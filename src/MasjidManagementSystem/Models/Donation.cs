using System.ComponentModel.DataAnnotations;

namespace MasjidManagementSystem.Models
{
	public class Donation
	{
		[Key]
		public string DonarName { get; set; }
		public int Amount { get; set; }
		public string DonationDate { get; set; }
	}
}
