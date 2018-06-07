using System.Collections.Generic;
using Metroiten.Data.Models;
using Metroiten.Services;
using Microsoft.AspNetCore.Mvc;

namespace Metroiten.Web.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantData _restaurantData;

        public RestaurantsController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IEnumerable<Restaurant> Get()
        {
            return _restaurantData.GetAllRestaurants();
        } 
    }
}