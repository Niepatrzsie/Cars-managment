using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car_managment.DAL;
using Car_managment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Car_managment.Controllers
{
    public class CarsController : Controller
    {
        private readonly IDbLayer _context;
        public CarsController(IDbLayer context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            ViewBag.Cars = _context.GetCars();
            ViewBag.Teams = _context.GetTeams();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Car newCar)
        {
            
            if (!ModelState.IsValid)
            {
                ViewBag.Cars = _context.GetCars();
                return View("Index", newCar);
            }

            _context.AddNewCar(newCar);
            return RedirectToAction("Index");
        }
        
    }
}