using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Loan
    {
        [Key]
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public string DueDate { get; set; }
    }
}
