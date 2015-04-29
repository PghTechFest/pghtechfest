namespace PghTechFest.Www.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class scheduleshit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Room_Id = c.Int(),
                        Session_Id = c.Int(),
                        TimeSlot_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.Room_Id)
                .ForeignKey("dbo.Sessions", t => t.Session_Id)
                .ForeignKey("dbo.ScheduleSlots", t => t.TimeSlot_Id)
                .Index(t => t.Room_Id)
                .Index(t => t.Session_Id)
                .Index(t => t.TimeSlot_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schedules", "TimeSlot_Id", "dbo.ScheduleSlots");
            DropForeignKey("dbo.Schedules", "Session_Id", "dbo.Sessions");
            DropForeignKey("dbo.Schedules", "Room_Id", "dbo.Rooms");
            DropIndex("dbo.Schedules", new[] { "TimeSlot_Id" });
            DropIndex("dbo.Schedules", new[] { "Session_Id" });
            DropIndex("dbo.Schedules", new[] { "Room_Id" });
            DropTable("dbo.Schedules");
            DropTable("dbo.Rooms");
        }
    }
}
