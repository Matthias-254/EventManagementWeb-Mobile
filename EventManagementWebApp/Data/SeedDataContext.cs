using EventManagementWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EventManagementWebApp.Data
{
    public class SeedDataContext
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            context.Database.Migrate();

            if (!context.Location.Any())
            {
                context.Location.AddRange(
                    new Location { Name = "?", Address = "?", Description = "?", Deleted = DateTime.Now },
                    new Location { Name = "Kasteel van Huizingen", Address = "Henry Torleylaan 100, 1654 Huizingen", Description = "Huizingen Castle is a castle with domain in the municipality of Beersel, belonging to the Flemish Brabant" }
                );
                context.SaveChanges();
            }

            if (!context.Event.Any())
            {
                Location location = context.Location.FirstOrDefault(l => l.Name == "?");
                context.Event.AddRange(
                    new Event { Name = "?", Description = "?", Deleted = DateTime.Now, LocationId = location.Id },
                    new Event { Name = "Wine tasting Evening", Description = "New local wine tasting time.", Location = location }
                    );
                context.SaveChanges();
            }

        }
    }
}
