using LaptopECommerce.Models;

namespace LaptopECommerce.Data.Services
{
    public interface ILaptopsService
    {
        Task<IEnumerable<Laptop>> GetAllAsync();
        
        Task<Laptop> GetByIdAsync(int id);

        Task AddAsync(Laptop laptop);

        Laptop Update(int id, Laptop newLaptop);

        void Delete(int id);
    }
}
