using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metroiten.Data;
using Metroiten.Models;
using SQLitePCL;

namespace Metroiten.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private MetroitenDbContext _context;

        public SqlRestaurantData(MetroitenDbContext condex)
        {
            _context = condex;
        }

        public IEnumerable<Restaurant> GetAllRestaurants() => _context.Restaurants.OrderBy(x => x.Name);

        public Restaurant GetById(int id) => _context.Restaurants.FirstOrDefault(x => x.Id == id);

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }
    }
}
