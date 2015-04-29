using System.ComponentModel.DataAnnotations.Schema;

namespace PghTechFest.Www.Models.Domain
{
    [Table("Rooms")]
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}