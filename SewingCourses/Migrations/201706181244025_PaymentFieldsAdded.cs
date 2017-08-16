namespace SewingCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentFieldsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "DateMade", c => c.DateTime(nullable: false));
            AddColumn("dbo.Payments", "Amount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "Amount");
            DropColumn("dbo.Payments", "DateMade");
        }
    }
}
