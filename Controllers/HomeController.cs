using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lost_in_the_Woods.Models;
using Lost_in_the_Woods.Factory;

namespace Lost_in_the_Woods.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailFactory TrailFactory;
        public IActionResult Index()
        {
            ViewBag.allTrails = TrailFactory.GetAllTrails();
            return View();
        }
        [HttpGet]
        [Route("/{id}")]
        public IActionResult Find(int id)
        {
            ViewBag.Trail = TrailFactory.FindTrail(id);
            return View("Trail");
        }
        [Route("/new")]
        public IActionResult New()
        {
            return View("New");
        }
        [HttpPost]
        [Route("/Trail/create")]
        public IActionResult Create(TrailViewModel model)
        {
            if (ModelState.IsValid)
            {
                Trail newTrail = new Trail
                {
                    Name = model.Name,
                    Description = model.Description,
                    Length = model.Length,
                    Elevation = model.Elevation,
                    Longitude = model.Longitude,
                    Latitude = model.Latitude,
                };
                TrailFactory.AddNewTrail(newTrail);
            }
            else
            {
                // ViewBag.errors = ModelState.Values;
                return View("New");
            }
            return RedirectToAction("Index");
        }
    }
}
