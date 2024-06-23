using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace TicketTrackingSystem.Models
{
    public class AppUser: IdentityUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        [ForeignKey("Role")] // Foreign key for Role
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
        public ICollection<Bug> Bugs { get; set; } // Navigation property for Bugs created by this user
    }
}
