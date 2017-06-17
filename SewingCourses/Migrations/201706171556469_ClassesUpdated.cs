namespace SewingCourses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassesUpdated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PaymentId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        MadeDate = c.DateTime(nullable: false),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReservationId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        PersonId = c.Int(nullable: false),
                        Classes_ClassesId = c.Int(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.People", t => t.PersonId)
                .ForeignKey("dbo.Classes", t => t.Classes_ClassesId)
                .Index(t => t.PersonId)
                .Index(t => t.Classes_ClassesId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        PersonId = c.Int(nullable: false),
                        Specialisation = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.People", t => t.PersonId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.CareTakers",
                c => new
                    {
                        PersonId = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId)
                .ForeignKey("dbo.People", t => t.PersonId)
                .Index(t => t.PersonId);
            
            AddColumn("dbo.Classes", "LocationId", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "TeacherId", c => c.Int(nullable: false));
            CreateIndex("dbo.Classes", "LocationId");
            CreateIndex("dbo.Classes", "TeacherId");
            AddForeignKey("dbo.Classes", "LocationId", "dbo.Locations", "LocationId", cascadeDelete: true);
            AddForeignKey("dbo.Classes", "TeacherId", "dbo.Teachers", "PersonId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CareTakers", "PersonId", "dbo.People");
            DropForeignKey("dbo.Teachers", "PersonId", "dbo.People");
            DropForeignKey("dbo.Students", "Classes_ClassesId", "dbo.Classes");
            DropForeignKey("dbo.Students", "PersonId", "dbo.People");
            DropForeignKey("dbo.Classes", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Classes", "LocationId", "dbo.Locations");
            DropIndex("dbo.CareTakers", new[] { "PersonId" });
            DropIndex("dbo.Teachers", new[] { "PersonId" });
            DropIndex("dbo.Students", new[] { "Classes_ClassesId" });
            DropIndex("dbo.Students", new[] { "PersonId" });
            DropIndex("dbo.Classes", new[] { "TeacherId" });
            DropIndex("dbo.Classes", new[] { "LocationId" });
            DropColumn("dbo.Classes", "TeacherId");
            DropColumn("dbo.Classes", "LocationId");
            DropTable("dbo.CareTakers");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Reservations");
            DropTable("dbo.Payments");
            DropTable("dbo.People");
            DropTable("dbo.Locations");
        }
    }
}
