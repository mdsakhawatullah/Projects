using System.ComponentModel.DataAnnotations;

namespace MasjidManagementSystem.Models
{
	public class Imam
	{
		[Key]
		public string Name { get; set; }
		public string HireDate { get; set; }
		public string Qualification { get; set; }

	}
}
