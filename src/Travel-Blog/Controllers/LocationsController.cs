﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Travel_Blog.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Travel_Blog.Controllers
{
    public class LocationsController : Controller
    {
        // GET: /<controller>/
        private WorldTravelBlogContext db = new WorldTravelBlogContext();
        public IActionResult Index()
        {
            return View(db.Locations.ToList());
        }
        public IActionResult Names(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(Locations => Locations.LocationId == id);
            return View(thisLocation);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Location location)
        {
            db.Locations.Add(location);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            return View(thisLocation);
        }

        [HttpPost]
        public IActionResult Edit(Location location)
        {
            db.Entry(location).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            return View(thisLocation);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            db.Locations.Remove(thisLocation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}





