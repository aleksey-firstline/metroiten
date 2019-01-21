using System.ComponentModel.DataAnnotations;
using Metroiten.Data.Models;

namespace Metroiten.ViewModel
{
    public class RestauranEditModel
    {
        [Required, MaxLength(5)]
        public string Name { get; set; }
        public string Description { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
