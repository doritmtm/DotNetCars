using DotNetCarsWebsite.Data;
using DotNetCarsWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCarsWebsite.Controllers
{
    public class CarController : Controller
    {
        private readonly CarsDbContext CarsDb;
        public CarController(CarsDbContext carsDb)
        {
            CarsDb = carsDb;
        }

        public IActionResult Index()
        {
            List<Car> Cars = CarsDb.Cars.ToList();
            return View(Cars);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car newCar)
        {
            if(ModelState.IsValid)
            {
                CarsDb.Cars.Add(newCar);
                CarsDb.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newCar);
        }
    }
}
