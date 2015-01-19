using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PghTechFest.Components.Domain
{
    [Table("People")]
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }

    [Table("Sessions")]
    public class Session
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public IEnumerable<Person> Speakers { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    [Table("ScheduleSlots")]
    public class ScheduleSlot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}
