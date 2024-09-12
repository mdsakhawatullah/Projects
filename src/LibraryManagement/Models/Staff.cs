using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Staff
    {
        [Key]
        public string Name { get; set; }
        public int StaffId { get; set; }
        public string Position { get; set; }
    }
}
