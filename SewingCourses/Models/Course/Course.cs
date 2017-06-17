using SewingCourses.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SewingCourses.Models
{
    public abstract class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        [DisplayName("Nazwa")]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        public string Type { get {
                return this is NormalCourse ? "Normalny" : this is ProfessionalCourse ? "Zawodowy" : "Semestralny";
        }}

        [DisplayName("Cena")]
        [Required]
        public float Price { get; set; }

        [DisplayName("Min. wiek uczestnika")]
        public int MinParticipantAge { get; set; }

        [DisplayName("Max. wiek uczestnika")]
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
