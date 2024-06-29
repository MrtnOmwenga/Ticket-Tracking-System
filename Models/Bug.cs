using System.ComponentModel.DataAnnotations.Schema;

namespace TicketTrackingSystem.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public required string Summary { get; set; }
        public string? Description { get; set; }
        public bool IsResolved { get; set; }
        public int CreatedById { get; set; }
        [NotMapped]
        public required AppUser CreatedBy { get; set; }
    }
}
