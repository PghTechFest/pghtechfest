namespace PghTechFest.Www.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class otherstuff : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScheduleSlots", "StartTime", c => c.String());
            AddColumn("dbo.ScheduleSlots", "EndTime", c => c.String());
            AddColumn("dbo.ScheduleSlots", "Name", c => c.String());
            DropColumn("dbo.ScheduleSlots", "TimeStart");
            DropColumn("dbo.ScheduleSlots", "TimeEnd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ScheduleSlots", "TimeEnd", c => c.DateTime(nullable: false));
            AddColumn("dbo.ScheduleSlots", "TimeStart", c => c.DateTime(nullable: false));
            DropColumn("dbo.ScheduleSlots", "Name");
            DropColumn("dbo.ScheduleSlots", "EndTime");
            DropColumn("dbo.ScheduleSlots", "StartTime");
        }
    }
}
