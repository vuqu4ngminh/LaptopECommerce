﻿using System.ComponentModel.DataAnnotations;

namespace LaptopECommerce.Models
{
    public class Laptop
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
