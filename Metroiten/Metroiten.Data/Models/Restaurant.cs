using System.ComponentModel.DataAnnotations;

namespace Metroiten.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Display(Name = "Restaurant Name")]
        [Required, MaxLength(5)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
