using SewingCourses.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingCourses.Models
{
    abstract class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        public string Name { get; set; }

        public string Type { get {
                return this is NormalCourse ? "Normalny" : this is ProfessionalCourse ? "Zawodowy" : "Semestralny";
        }}

        public float Price { get; set; }

        public int MinParticipantAge { get; set; }

        public int MaxParticipantAge { get; set; }

        public virtual ICollection<Classes> Classes { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public static void CreateCourse()
        {
            CourseAddingForm form = new CourseAddingForm();
            form.Show();
        }
    }
}
