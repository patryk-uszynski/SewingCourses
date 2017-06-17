namespace SewingCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ProfessionalCourses", "Qualifications", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProfessionalCourses", "Qualifications", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
        }
    }
}
