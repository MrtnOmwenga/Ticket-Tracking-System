using System.ComponentModel.DataAnnotations;

namespace TicketTrackingSystem.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<AppUser> AppUsers { get; set; } // Navigation property for AppUsers with this role
    }
}
