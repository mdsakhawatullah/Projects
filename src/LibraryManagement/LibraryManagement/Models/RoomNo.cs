using System.ComponentModel.DataAnnotations;

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

	}
}
