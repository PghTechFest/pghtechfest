using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PghTechFest.Www.Models.Domain
{
    [Table("Sessions")]
    public class Session
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Person Speaker { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name = "Length in Minutes")]
        public int? LengthInMinutes { get; set; }
        public Track Track { get; set; }
    }
}
