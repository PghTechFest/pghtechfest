using System.ComponentModel.DataAnnotations.Schema;

namespace PghTechFest.Www.Models.Domain
{
    [Table("Schedules")]
    public class Schedule
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Session Session { get; set; }

        public ScheduleSlot TimeSlot { get; set; }

        public Room Room { get; set; }
    }
}