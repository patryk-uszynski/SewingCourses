using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingCourses.Models
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Capacity { get; set; }

        public virtual IList<Classes> Classes { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
