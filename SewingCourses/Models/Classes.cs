using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingCourses.Models
{
    public class Classes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassesId { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDateTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDateTime { get; set; }

        public virtual int FreeSpots { get { return GetSpotsLeft(); } }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual string TeacherName { get { return Teacher.FirstName + " " + Teacher.LastName; } }

        public virtual ICollection<Student> Students { get; set; }

        /// <summary>
        ///     Get number of free spots left in classes
        /// </summary>
        /// <returns>Number of free spots</returns>
        public int GetSpotsLeft()
        {
            int totalSpots = this.Location.Capacity;
            int takenSpots = Students != null ? Students.Count() : 0;
            return totalSpots - takenSpots;
        }

        /// <summary>
        ///     Checks if course has free spots
        /// </summary>
        /// <returns>bool</returns>
        public bool HasFreeSpots()
        {
            return GetSpotsLeft() > 0;
        }


        /// <summary>
        ///     Generates attendance list
        /// </summary>
        /// <returns>String - attendance list</returns>
        public string generateAttendanceList()
        {
            String attendanceList = Course.Name + "\n";

            foreach (var student in Students)
            {
                attendanceList += "[ ] " + student.FirstName + " " + student.LastName;
            }

            return attendanceList;
        }
    }

}
