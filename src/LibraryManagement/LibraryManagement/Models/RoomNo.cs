using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class RoomNo
    {
        [Key]
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
		public bool IsSubscribed { get; set; }
		public string Gender { get; set; }
		public string SelectedCountry { get; set; }
		public TimeSpan PreferTime { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Level { get; set; }
		public int Age { get; set; }
		[NotMapped]
		public IFormFile UploadedFile { get; set; }
		public string? FileName { get; set; }

	}
}
