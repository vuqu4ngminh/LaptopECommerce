using LaptopECommerce.Models;

namespace LaptopECommerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                if (!context.Laptops.Any())
                {
                    context.Laptops.AddRange(new List<Laptop>()
                    {
                        new Laptop()
                        {
                            Name = "Laptop 1",
                            Description = "CPU: Ryzen 5, VGA: Radeon Graphic, RAM: 8GB, SSD: 256GB",
                            Price = 10000000,
                            ImageURL = "https://cdn.tgdd.vn/Products/Images/44/305010/asus-vivobook-x515ea-i3-ej3948w-1.jpg",
                            Status = "1"
                        },
                        new Laptop()
                        {
                            Name = "Laptop 2",
                            Description = "CPU: Ryzen 7, VGA: Mx550, RAM: 8GB, SSD: 512GB",
                            Price = 15000000,
                            ImageURL = "https://cdn.tgdd.vn/Products/Images/44/309293/dell-inspiron-3520-i3-71003264-2.jpg",
                            Status = "0"
                        },
                        new Laptop()
                        {
                            Name = "Laptop 3",
                            Description = "CPU: I5 1210U, VGA: UHD Graphic, RAM: 8GB, SSD: 512GB",
                            Price = 15000000,
                            ImageURL = "https://cdn.tgdd.vn/Products/Images/44/310839/asus-vivobook-15-oled-a1505va-i5-l1341w-2.jpg",
                            Status = "1"
                        },
                        new Laptop()
                        {
                            Name = "Laptop 4",
                            Description = "CPU: I3 1210U, VGA: UHD Graphic, RAM: 16GB, SSD: 256GB",
                            Price = 12000000,
                            ImageURL = "https://cdn.tgdd.vn/Products/Images/44/304539/msi-modern-14-c11m-i3-011vn-glr-2.jpg",
                            Status = "1"
                        },
                    }) ;
                    context.SaveChanges();
                }
            }
        }
    }
}
