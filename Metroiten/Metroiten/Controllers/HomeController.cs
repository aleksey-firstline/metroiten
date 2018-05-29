using Metroiten.Models;
using Metroiten.Services;
using Metroiten.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Metroiten.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurantData;
        private IGreeting _greeting;

        public HomeController(IRestaurantData restaurantData, IGreeting greeting)
        {
            _restaurantData = restaurantData;
            _greeting = greeting;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeIndexViewModel
            {
                Restaurants = _restaurantData.GetAllRestaurants(),
                Message = _greeting.GetMessage()
            };

            return View(viewModel);
        }

        public IActionResult Detail(int id)
        {
            var restauran = _restaurantData.GetById(id);

            if (restauran == null)
                return RedirectToAction(nameof(Index));

            return View(restauran);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestauranEditModel editModel)
        {
            if (ModelState.IsValid)
            {
                var restauran = new Restaurant
                {
                    Name = editModel.Name,
                    Cuisine = editModel.Cuisine
                };

                _restaurantData.Add(restauran);

                return RedirectToAction(nameof(Detail), new { restauran.Id });
            }
            else
            {
                return View();
            }
        }
    }
}
