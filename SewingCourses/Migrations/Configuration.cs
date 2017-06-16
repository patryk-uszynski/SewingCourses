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
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //NormalCourse course1 = new NormalCourse { CourseId = 1, Name = "Wstep do szycia", Price = 100.0F };
            //NormalCourse course2 = new NormalCourse { CourseId = 1, Name = "Wstep do szycia", Price = 100.0F };

            context.Courses.AddOrUpdate(
                c => c.CourseId, 
                new NormalCourse { CourseId = 1, Name = "Wstêp do szycia", Price = 100.0F },
                new NormalCourse { CourseId = 2, Name = "Podstawy szycia", Price = 200.0F }
            );

            context.Classes.AddOrUpdate(
                c => c.ClassesId, new Classes {
                    ClassesId = 1,
                    CourseId = 1,
                    StartDateTime = DateTime.Now.AddDays(1),
                    EndDateTime = DateTime.Now.AddDays(1)
                },
                new Classes {
                    ClassesId = 1,
                    CourseId = 1,
                    StartDateTime = DateTime.Now.AddDays(1),
                    EndDateTime = DateTime.Now.AddDays(1)
                }
            );
            //context.Classes.AddOrUpdate(
            //    new Classes {
            //        ClassesId = 1,
            //        StartDateTime = DateTime.Now.AddDays(1),
            //        EndDateTime = DateTime.Now.AddDays(1),
            //        Course = course1
            //    },
            //     new Classes
            //     {
            //         ClassesId = 2,
            //         StartDateTime = DateTime.Now.AddDays(1),
            //         EndDateTime = DateTime.Now.AddDays(1),
            //         Course = course2
            //     }
            //);

        }
    }
}
