using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }


    }
}
