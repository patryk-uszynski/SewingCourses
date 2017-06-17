using SewingCourses.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingCourses.Persistence
{
    public class SewingCoursesDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Classes> Classes { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Reservation> Reservations { get; set; }
    }
}
