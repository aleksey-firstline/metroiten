using Metroiten.Data.Models;
using Metroiten.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metroiten.Data.Services
{
    public class FakeRestouranData : IRestaurantData
    {
        private static List<Restaurant> restaurants = new List<Restaurant>();

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = new Random().Next();
            restaurants.Add(restaurant);
            return restaurant;
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return restaurants;
        }

        public Restaurant GetById(int id)
        {
            return restaurants.FirstOrDefault(x => x.Id == id);
        }

        public Restaurant Update(Restaurant restaurant)
        {
            restaurants.RemoveAll(x => x.Id == restaurant.Id);
            restaurants.Add(restaurant);
            return restaurant;
        }
    }
}
