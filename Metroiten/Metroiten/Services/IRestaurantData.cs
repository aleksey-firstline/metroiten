using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metroiten.Models;

namespace Metroiten.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAllRestaurants();
        Restaurant GetById(int id);
        Restaurant Add(Restaurant restaurant);
    }
}
