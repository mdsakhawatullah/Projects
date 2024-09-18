using System.ComponentModel.DataAnnotations;

namespace MasjidManagementSystem.Models
{
    public class Event
    {
        [Key]
        public string EventName { get; set; }
        public DateTime Date {  get; set; }
        public string Location { get; set; }
    }
}
