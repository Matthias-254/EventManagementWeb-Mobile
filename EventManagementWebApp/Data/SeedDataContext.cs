using EventManagementWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EventManagementWebApp.Data
{
    public class SeedDataContext
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            //context.Database.Migrate();

            if (!context.Location.Any())
            {
                context.Location.AddRange(
                    new Location { Name = "?", Address = "?", Description = "?", Deleted = DateTime.Now },
                    new Location { Name = "Kasteel van Huizingen", Address = "Henry Torleylaan 100, 1654 Huizingen", Description = "Huizingen Castle is a castle with domain in the municipality of Beersel, belonging to the Flemish Brabant." },
                    new Location { Name = "Le Grand Salon", Address = "Herman Teirlinckplein 4, 1650 Beersel", Description = "A new event hall with a surprise effect for your guests." },
                    new Location { Name = "Feestzaal Ter Heyde", Address = "Kesterweg 35, 1755 Gooik", Description = "Planning for your business, introducing a new product to your customers or building your team." }
                );
                context.SaveChanges();
            }

            if (!context.Event.Any())
            {
                Location location = context.Location.FirstOrDefault(l => l.Name == "?");
                context.Event.AddRange(
                    new Event { Name = "?", Description = "?", Deleted = DateTime.Now, LocationId = location.Id },
                    new Event { Name = "Wine tasting Evening", Description = "New local wine tasting time.", LocationId = 2 },
                    new Event { Name = "Kunsttentoonstelling", Description = "Art exhibition of all kinds of artists from the region", LocationId = 3 },
                    new Event { Name = "Boekenbeurs", Description = "Book fair of various books made by authors from the region", LocationId = 4 }
                    );
                context.SaveChanges();
            }

            if (!context.Staff.Any())
            {
                context.Staff.AddRange(
                    new Staff { Name = "John", FirstName = "John", LastName = "Doe", Deleted = DateTime.Now },
                    new Staff { Name = "Jane", FirstName = "Jane", LastName = "Doe" },
                    new Staff { Name = "Joe", FirstName = "Joe", LastName = "Bloggs" }
                );
                context.SaveChanges();
            }
        }
    }
}
