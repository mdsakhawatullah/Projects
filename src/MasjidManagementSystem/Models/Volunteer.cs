using System.ComponentModel.DataAnnotations;

namespace MasjidManagementSystem.Models
{
	public class Volunteer
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Role { get; set; }
		public string ContactNumber { get; set; }
		public bool IsSubscribed { get; set; }
		public string Gender { get; set; }
		public string SelectedCountry { get; set; }
		public TimeSpan PreferTime { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Level { get; set; }
		public int Age { get; set; }
	}
}
