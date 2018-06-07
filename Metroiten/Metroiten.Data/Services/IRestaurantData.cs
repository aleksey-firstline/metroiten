using System.Collections.Generic;
using Metroiten.Data.Models;

namespace Metroiten.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAllRestaurants();
        Restaurant GetById(int id);
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant restaurant);
    }
}
