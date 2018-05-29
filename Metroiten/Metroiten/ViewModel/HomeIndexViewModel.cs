using System.Collections.Generic;
using Metroiten.Models;

namespace Metroiten.ViewModel
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Message { get; set; }
    }
}
