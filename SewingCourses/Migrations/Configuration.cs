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

            context.Locations.AddOrUpdate(
                c => c.LocationId,
                new Location { LocationId = 1, Name = "Sala g³ówna", Address = "Wawelska 42, 01-100 Warszawa", Capacity = 20 },
                new Location { LocationId = 2, Name = "Sala dodatkowa", Address = "Wawelska 42, 01-100 Warszawa", Capacity = 10 }
            );

            context.Persons.AddOrUpdate(
                c => c.PersonId,
                new Teacher { PersonId = 1, FirstName = "Jan", LastName = "Kowalski", Specialisation = "Szyde³ko" },
                new Student { PersonId = 2, FirstName = "Stefan", LastName = "Czarniecki", BirthDate = DateTime.Parse("01.01.1980")},
                new Student { PersonId = 3, FirstName = "Kamil", LastName = "Pêdrak", BirthDate = DateTime.Parse("01.01.1980") }
            );

            context.Classes.AddOrUpdate(
                c => c.ClassesId,
                new Classes
                {
                    ClassesId = 1,
                    CourseId = 1,
                    StartDateTime = DateTime.Now.AddDays(1),
                    EndDateTime = DateTime.Now.AddDays(1),
                    TeacherId = 1,
                    LocationId = 1
                },
                new Classes
                {
                    ClassesId = 1,
                    CourseId = 2,
                    StartDateTime = DateTime.Now.AddDays(2),
                    EndDateTime = DateTime.Now.AddDays(2),
                    TeacherId = 1,
                    LocationId = 2
                }
            );
        }
    }
}
