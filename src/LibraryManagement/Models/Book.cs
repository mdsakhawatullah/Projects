using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
	public class Book
	{
		[Key]
		public string Title { get; set; }
		public string Author { get; set; }
		public string ISBN { get; set; }

	}
}
