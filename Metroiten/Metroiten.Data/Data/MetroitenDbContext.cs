using Metroiten.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Metroiten.Data.Data
{
    public class MetroitenDbContext : DbContext
    {
        public MetroitenDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}
