using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SewingCourses.Models
{
    [Table("ProfessionalCourses")]
    class ProfessionalCourse : Course
    {
        [Required(AllowEmptyStrings = false)]
        public string Qualifications { get; set; }
    }
}
