namespace SewingCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedClasess : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassesId = c.Int(nullable: false, identity: true),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassesId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "CourseId", "dbo.Courses");
            DropIndex("dbo.Classes", new[] { "CourseId" });
            DropTable("dbo.Classes");
        }
    }
}
