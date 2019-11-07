using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class SquirrelsController : Controller
    {
        // GET: Squirrels
        public ActionResult Index()
        {
            Squirrel kathrine = new Squirrel()
            {
                Name = "Katie",
                IsBushyTail = false,
                TeethSize = 3,
                ImageURL = @"https://www.freeapplewallpapers.com/wp-content/uploads/2013/06/Cute-Squirrel.jpg"
            };

            Squirrel adam = new Squirrel()
            {
                Name = "Adam",
                IsBushyTail = true,
                TeethSize = 5,
                ImageURL = @"https://cookieandkate.com/images/2010/11/squirrel-1.jpg"
            };

            List<Squirrel> squirrels = new List<Squirrel>();
            squirrels.Add(kathrine);
            squirrels.Add(adam);

            return View(squirrels);
        }

        /*
        // GET: Squirrels/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Squirrels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Squirrels/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Squirrels/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Squirrels/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Squirrels/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Squirrels/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        */       
    }
}
