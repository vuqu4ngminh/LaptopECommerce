using System.ComponentModel.DataAnnotations;

namespace LaptopECommerce.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Image is required")]
        public string ImageURL { get; set; }

        public bool Status { get; set; }
    }
}
