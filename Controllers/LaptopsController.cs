using LaptopECommerce.Data;
using LaptopECommerce.Data.Services;
using LaptopECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            var data = await _service.GetAll();
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
            
            _service.Add(laptop);
            return RedirectToAction(nameof(Index));
        }
    }
}
