using CarDealer.Data;
using CarDealer.Models;
using CarDealer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.Controllers;

public class CarsController : Controller
{
    private readonly ApplicationDbContext _context;

    public CarsController(ApplicationDbContext context)
    {
        _context = context;
    }

    
    public async Task<IActionResult> Index ()
    {
        var cars = await _context.Cars.ToListAsync();

        var viewModel = new CarListViewModel
        {
            Cars = cars,
            TotalCars = cars.Count
        };

        return View(viewModel); 
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Car car)
    //public IActionResult Create(Car car)
    {
        _context.Cars.Add(car);

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));

        //return View();
    }
}