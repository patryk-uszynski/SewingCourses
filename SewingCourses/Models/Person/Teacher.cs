using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SewingCourses.Models
{
    [Table("Teachers")]
    public class Teacher : Person
    {
        [Required]
        public string Specialisation { get; set; }

        public virtual IList<Classes> Classes { get; set; }
    }
}
