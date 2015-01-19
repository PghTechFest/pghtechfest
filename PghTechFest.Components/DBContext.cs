using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PghTechFest.Components
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("PghTechFest") { }

        public DbSet<Domain.Person> People { get; set; }
        public DbSet<Domain.ScheduleSlot> ScheduleSlots { get; set; }
        public DbSet<Domain.Session> Sessions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
