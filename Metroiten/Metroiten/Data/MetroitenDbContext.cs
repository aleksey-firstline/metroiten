using Metroiten.Models;
using Microsoft.EntityFrameworkCore;

namespace Metroiten.Data
{
    public class MetroitenDbContext : DbContext
    {
        public MetroitenDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
