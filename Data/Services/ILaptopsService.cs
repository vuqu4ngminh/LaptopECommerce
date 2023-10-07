using LaptopECommerce.Models;

namespace LaptopECommerce.Data.Services
{
    public interface ILaptopsService
    {
        Task<IEnumerable<Laptop>> GetAllAsync();
        
        Task<Laptop> GetByIdAsync(int id);

        Task AddAsync(Laptop laptop);

        Task<Laptop> UpdateAsync(int id, Laptop newLaptop);

        Task DeleteAsync(int id);
    }
}
