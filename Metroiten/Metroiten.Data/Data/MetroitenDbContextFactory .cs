using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Metroiten.Data.Data
{
    public class MetroitenDbContextFactory : IDesignTimeDbContextFactory<MetroitenDbContext>
    {
        public MetroitenDbContextFactory()
        {
        }

        public MetroitenDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MetroitenDbContext>();
            builder.UseSqlServer(
                "Data Source=AGALATIN;Integrated Security=True;Database=MetroitenRestauran;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new MetroitenDbContext(builder.Options);
        }
    }
}
