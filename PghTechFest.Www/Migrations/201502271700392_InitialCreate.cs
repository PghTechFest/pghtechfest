namespace PghTechFest.Www.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                        Bio = c.String(nullable: false),
                        AvatarUrl = c.String(),
                        TwitterUserName = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ScheduleSlots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeStart = c.DateTime(nullable: false),
                        TimeEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        LengthInMinutes = c.Int(),
                        Tracks = c.String(nullable: false),
                        Speaker_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Speaker_Id, cascadeDelete: true)
                .Index(t => t.Speaker_Id);
            
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sessions", "Speaker_Id", "dbo.People");
            DropIndex("dbo.Sessions", new[] { "Speaker_Id" });
            DropTable("dbo.Tracks");
            DropTable("dbo.Sessions");
            DropTable("dbo.ScheduleSlots");
            DropTable("dbo.People");
        }
    }
}
