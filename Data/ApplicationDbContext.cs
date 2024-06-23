using Microsoft.EntityFrameworkCore;
using TicketTrackingSystem.Models;

namespace TicketTrackingSystem.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Bug> Bugs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed roles if necessary
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "QA" },
                new Role { Id = 2, Name = "RD" },
                new Role { Id = 3, Name = "PM" },
                new Role { Id = 4, Name = "Administrator" }
            );

            modelBuilder.Entity<AppUser>()
                .HasOne(u => u.Role)
                .WithMany(r => r.AppUsers)
                .HasForeignKey(u => u.RoleId)
                .IsRequired();
        }
    }
}
