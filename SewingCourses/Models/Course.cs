using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingCourses.Models
{
    class Course
    {
        public int CourseId { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public int MinParticipantAge { get; set; }

        public int MaxParticipantAge { get; set; }

    }
}
