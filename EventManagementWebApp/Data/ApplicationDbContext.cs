using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EventManagementWebApp.Models;

namespace EventManagementWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EventManagementWebApp.Models.Event> Event { get; set; } = default!;
        public DbSet<EventManagementWebApp.Models.Location> Location { get; set; } = default!;
    }
}
