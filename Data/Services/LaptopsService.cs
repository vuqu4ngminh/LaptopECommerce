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

        public void Delete(int id)
        {
            throw new NotImplementedException();
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

        public Laptop Update(int id, Laptop newLaptop)
        {
            throw new NotImplementedException();
        }
    }
}
