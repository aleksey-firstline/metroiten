using System.ComponentModel.DataAnnotations;

namespace Metroiten.Data.Models
{
    public class Dish
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Currency Currency { get; set; }
        public string Description { get; set; }
        [Required]
        public MenuType MenuType { get; set; }
    }
}
