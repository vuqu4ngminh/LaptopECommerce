using LaptopECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace LaptopECommerce.Data.Services
{

    public class LaptopsService : ILaptopsService
    {
        private readonly AppDbContext _context;

        public LaptopsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Laptop laptop)
        {
            _context.Laptops.Add(laptop);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Laptop>> GetAll()
        {
            var result = await _context.Laptops.ToListAsync();
            return result;
        }

        public Laptop GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Laptop Update(int id, Laptop newLaptop)
        {
            throw new NotImplementedException();
        }
    }
}
