using LaptopECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace LaptopECommerce.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        
        public DbSet<Laptop> Laptops { get; set; }
    }
}
