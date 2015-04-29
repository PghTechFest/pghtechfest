using System.Collections.Generic;
using PghTechFest.Www.Models.Domain;

namespace PghTechFest.Www.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PghTechFest.Www.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PghTechFest.Www.Models.DatabaseContext";
        }

        protected override void Seed(PghTechFest.Www.Models.DatabaseContext context)
        {
            new List<Room>
            {
                new Room { Id = 1, Name = "Gym"},
                new Room { Id = 2, Name = "105"},
                new Room { Id = 3, Name = "2xx-1"},
                new Room { Id = 4, Name = "2xx-2"},
                new Room { Id = 5, Name = "103"},
                new Room { Id = 6, Name = "108"},
                new Room { Id = 7, Name = "107"},
                new Room { Id = 8, Name = "106"},
                new Room { Id = 9, Name = "Cafeteria"}
            }.ForEach(x => context.Rooms.Add(x));

            new List<ScheduleSlot>
            {
                new ScheduleSlot { Id = 1, StartTime = "8:30 AM", EndTime="9:05 AM", Name = "Keynote"},
                new ScheduleSlot { Id = 2, StartTime = "9:20 AM", EndTime="10:20 AM", Name = "Session 1"},
                new ScheduleSlot { Id = 3, StartTime = "10:35 AM", EndTime="11:05 AM", Name = "Session 2"},
                new ScheduleSlot { Id = 4, StartTime = "11:20 AM", EndTime="12:20 PM", Name = "Session 3A"},
                new ScheduleSlot { Id = 5, StartTime = "12:05 PM", EndTime="1:05 PM", Name = "Session 3B"},
                new ScheduleSlot { Id = 6, StartTime = "11:05 PM", EndTime="1:05 PM", Name = "Lunch"},
                new ScheduleSlot { Id = 7, StartTime = "1:20 PM", EndTime="1:50 PM", Name = "Session 4"},
                new ScheduleSlot { Id = 8, StartTime = "2:05 PM", EndTime="2:35 PM", Name = "Session 5"},
                new ScheduleSlot { Id = 9, StartTime = "2:35 PM", EndTime="3:05 PM", Name = "Snack Break"},
                new ScheduleSlot { Id = 10, StartTime = "3:05 PM", EndTime="3:35 PM", Name = "Session 6"},
                new ScheduleSlot { Id = 11, StartTime = "3:50 PM", EndTime="4:50 PM", Name = "Session 7"},
                new ScheduleSlot { Id = 12, StartTime = "5:00 PM", EndTime="5:30 PM", Name = "Closing"}
            }.ForEach(x => context.ScheduleSlots.Add(x));
        }
    }
}
