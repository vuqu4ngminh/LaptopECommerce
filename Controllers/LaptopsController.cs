using LaptopECommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LaptopECommerce.Controllers
{
    public class LaptopsController : Controller
    {
        private readonly AppDbContext _context;
        public LaptopsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Laptops.ToListAsync();
            return View(data);
        }
    }
}
