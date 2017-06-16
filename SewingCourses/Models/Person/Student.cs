using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingCourses.Models
{
    class Student : Person
    {
        public DateTime BirthDate { get; set; }

        public int Age { get {
            var today = DateTime.Today;
            return today.Year - BirthDate.Year;
        }}
    }
}
