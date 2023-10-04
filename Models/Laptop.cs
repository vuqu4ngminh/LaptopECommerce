using System.ComponentModel.DataAnnotations;

namespace LaptopECommerce.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không được để trống")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Giá không được để trống")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Đường dẫn không được để trống")]
        public string ImageURL { get; set; }

        public string Status { get; set; }
    }
}
