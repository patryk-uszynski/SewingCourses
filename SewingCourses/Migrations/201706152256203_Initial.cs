namespace SewingCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        MinParticipantAge = c.Int(nullable: false),
                        MaxParticipantAge = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.NormalCourses",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.ProfessionalCourses",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        Qualifications = c.String(),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "dbo.SemesterCourses",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SemesterCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.ProfessionalCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.NormalCourses", "CourseId", "dbo.Courses");
            DropIndex("dbo.SemesterCourses", new[] { "CourseId" });
            DropIndex("dbo.ProfessionalCourses", new[] { "CourseId" });
            DropIndex("dbo.NormalCourses", new[] { "CourseId" });
            DropTable("dbo.SemesterCourses");
            DropTable("dbo.ProfessionalCourses");
            DropTable("dbo.NormalCourses");
            DropTable("dbo.Courses");
        }
    }
}
