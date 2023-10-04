using LaptopECommerce.Models;

namespace LaptopECommerce.Data.Services
{
    public interface ILaptopsService
    {
        Task<IEnumerable<Laptop>> GetAll();
        
        Laptop GetById(int id);

        void Add(Laptop laptop);

        Laptop Update(int id, Laptop newLaptop);

        void Delete(int id);
    }
}
