using System.ComponentModel.DataAnnotations;

namespace ProductWebApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
