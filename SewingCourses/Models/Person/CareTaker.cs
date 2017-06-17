using System.ComponentModel.DataAnnotations.Schema;

namespace SewingCourses.Models
{
    [Table("CareTakers")]
    public class CareTaker : Person
    {
        public string PhoneNumber { get; set; }
        public int StudentId { get; set; }
    }
}
