using Metroiten.Data.Models;
using Metroiten.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Metroiten.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantData _data;

        public EditModel(IRestaurantData data)
        {
            _data = data;
        }

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        public IActionResult OnGet(int id)
        {
            Restaurant = _data.GetById(id);
            if (Restaurant == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _data.Update(Restaurant);
                return RedirectToAction("Detail", "Home", new { id = Restaurant.Id });
            }

            return Page();
        }
    }
}