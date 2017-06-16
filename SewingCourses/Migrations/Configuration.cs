namespace SewingCourses.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SewingCourses.Persistence.SewingCoursesDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SewingCourses.Persistence.SewingCoursesDbContext context)
        {
            context.Courses.AddOrUpdate(
                c => c.CourseId, 
                new NormalCourse { CourseId = 1, Name = "Wstêp do szycia", Price = 100.0F },
                new NormalCourse { CourseId = 2, Name = "Podstawy szycia", Price = 200.0F }
            );

            context.Classes.AddOrUpdate(
                c => c.ClassesId, 
                new Classes {
                    ClassesId = 1,
                    CourseId = 1,
                    StartDateTime = DateTime.Now.AddDays(1),
                    EndDateTime = DateTime.Now.AddDays(1)
                },
                new Classes {
                    ClassesId = 1,
                    CourseId = 2,
                    StartDateTime = DateTime.Now.AddDays(2),
                    EndDateTime = DateTime.Now.AddDays(2)
                }
            );
        }
    }
}
