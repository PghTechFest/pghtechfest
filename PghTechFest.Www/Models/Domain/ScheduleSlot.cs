using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PghTechFest.Www.Models.Domain
{
    [Table("ScheduleSlots")]
    public class ScheduleSlot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Name { get; set; }
    }
}
