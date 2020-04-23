using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context {get;set;}
        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> Dishes = _context.Dishes.ToList();
            return View(Dishes);
        }
        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Dishes.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New");
            }
        }
        [HttpGet("{DishId}")]
        public IActionResult Show(int DishId)
        {
            Dish show = _context.Dishes.FirstOrDefault(e => e.DishId == DishId);
            return View(show);
        }
        [HttpGet("edit/{DishId}")]
        public IActionResult Edit(int DishId)
        {
            Dish edit = _context.Dishes.FirstOrDefault(e => e.DishId == DishId);
            return View(edit);
        }
        [HttpPost("update/{DishId}")]
        public IActionResult Update(int DishId, Dish editDish)
        {
            Dish grab = _context.Dishes.FirstOrDefault(e => e.DishId == DishId);
            if(ModelState.IsValid)
            {
                grab.Name = editDish.Name;
                grab.Chef = editDish.Chef;
                grab.Calories = editDish.Calories;
                grab.Tastiness = editDish.Tastiness;
                grab.Description = editDish.Description;
                grab.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return Redirect($"/{DishId}");
            }
            else
            {
                return View("Edit", editDish);
            }
        }
        [HttpGet("delete/{DishId}")]
        public IActionResult Delete(int DishId)
        {
            Dish grab = _context.Dishes.FirstOrDefault(e => e.DishId == DishId);
            _context.Dishes.Remove(grab);
            _context.SaveChanges();
            return Redirect("/");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
