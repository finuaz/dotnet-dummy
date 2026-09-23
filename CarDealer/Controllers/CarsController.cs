using CarDealer.Models;
using CarDealer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.CarControllers; 

public class CarsController : Controller
{
    public IActionResult Index ()
    {
        var cars = new List<Car>
        {
            new Car
            {
                Id = 1,
                Make = "Toyota",
                Model = "Avanza",
                Year = 2023,
                Price = 235000000,
                Mileage = 13000,
                Color = "Blue",
                IsNew = false
            },
            new Car
            {
                Id = 2,
                Make = "Honda",
                Model = "Civic",    
                Year = 2022,
                Price = 480000000,
                Mileage = 15000,
                Color = "Red",
                IsNew = false
            }
        };

        var viewModel = new CarListViewModel
        {
            Cars = cars,
            TotalCars = cars.Count
        };

        return View(viewModel); 
    }
}