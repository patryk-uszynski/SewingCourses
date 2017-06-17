using System.ComponentModel.DataAnnotations.Schema;

namespace SewingCourses.Models
{
    [Table("ProfessionalCourses")]
    class ProfessionalCourse : Course
    {
        public string Qualifications { get; set; }
    }
}
