using System.ComponentModel.DataAnnotations;

namespace Metroiten.Data.Models
{
    public class Currency
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public CurrencyCode Code { get; set; }
    }
}