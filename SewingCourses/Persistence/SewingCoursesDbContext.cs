using SewingCourses.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SewingCourses.Persistence
{
    class SewingCoursesDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public DbSet<Classes> Classes { get; set; }
    }
}
