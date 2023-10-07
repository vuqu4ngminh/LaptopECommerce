using LaptopECommerce.Data.Services;
using LaptopECommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaptopECommerce.Controllers
{
    public class LaptopsController : Controller
    {
        private readonly ILaptopsService _service;
        public LaptopsController(ILaptopsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Laptops/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Price,ImageURL,Description,Status")]Laptop laptop)
        {
            if(!ModelState.IsValid)
            {
                return View(laptop);
            }
            
            await _service.AddAsync(laptop);
            return RedirectToAction(nameof(Index));
        }

        //Get: Laptops/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var laptopDetails = await _service.GetByIdAsync(id);
            if(laptopDetails == null) return View("Empty");
            return View(laptopDetails);
        }
    }
}
