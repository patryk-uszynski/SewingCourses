using System;
using System.ComponentModel.DataAnnotations.Schema;
using SewingCourses.Persistence;
using System.Linq;
using System.Collections.Generic;

namespace SewingCourses.Models
{
    [Table("Students")]
    public class Student : Person
    {
        public DateTime BirthDate { get; set; }

        public int Age { get {
            var today = DateTime.Today;
            return today.Year - BirthDate.Year;
        }}

        public static IList<Student> FindStudent(String query)
        {
            List<Student> students = new List<Student>();
            query = query.ToLower();

            using (var context = new SewingCoursesDbContext())
            {
                students = context.Persons.OfType<Student>().Where(
                    x => x.FirstName.ToLower().Contains(query) ||
                         x.LastName.ToLower().Contains(query) ||
                         query.Contains(x.FirstName.ToLower()) ||
                         query.Contains(x.LastName.ToLower())
                ).ToList();
            }

            return students;
        }

        public static void AddStudent(Student newStudent)
        {
            using (var context = new SewingCoursesDbContext())
            {
                context.Persons.Add(newStudent);
                context.SaveChanges();
            }
        }

    }
}
