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
        public async Task AddAsync(Laptop laptop)
        {
            await _context.Laptops.AddAsync(laptop);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Laptops.FirstOrDefaultAsync(n => n.Id == id);
            _context.Laptops.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Laptop>> GetAllAsync()
        {
            var result = await _context.Laptops.ToListAsync();
            return result;
        }

        public async Task<Laptop> GetByIdAsync(int id)
        {
            var result = _context.Laptops.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public async Task<Laptop> UpdateAsync(int id, Laptop newLaptop)
        {
            _context.Update(newLaptop);
            await _context.SaveChangesAsync();
            return newLaptop;
        }
    }
}
