using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Loan
    {
        [Key]
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public string DueDate { get; set; }
		public bool IsSubscribed { get; set; }
		public string Gender { get; set; }
		public string SelectedCountry { get; set; }
		public TimeSpan PreferTime { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Level { get; set; }
		public int Age { get; set; }
	}
}
