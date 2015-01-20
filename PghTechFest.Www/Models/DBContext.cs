using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PghTechFest.Www.Models.Domain;

namespace PghTechFest.Www.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("PghTechFest") { }

        public DbSet<Person> People { get; set; }
        public DbSet<ScheduleSlot> ScheduleSlots { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    public class SeedData : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            new List<Track>
            {
                new Track { Id = 1, Name = "Agile/Process"},
                 new Track { Id = 2, Name = "JavaScript"},
                 new Track { Id = 3, Name = "Systems and Sciences"},
                 new Track { Id = 4, Name = "Mobile"},
                 new Track { Id = 5, Name = "Testing"},
                 new Track { Id = 6, Name = "Data"},
                 new Track { Id = 7, Name = "OO Languages"},
                 new Track { Id = 8, Name = "Functional Languages"},
                 new Track { Id = 9, Name = "Distributed Systems"},
                 new Track { Id = 10, Name = "Security"},
                 new Track { Id = 11, Name = "DevOps"},
                 new Track { Id = 12, Name = "Business/Soft Skills"}
            }.ForEach(x => context.Tracks.Add(x));
        }
    }
}
