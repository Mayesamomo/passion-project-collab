using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimeMusic.Controllers
{
    public class AnimeController : Controller
    {
        // GET: Anime
        public ActionResult Index()
        {
            return View();
        }

        // GET: Anime/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Anime/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anime/Create
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

        // GET: Anime/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Anime/Edit/5
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

        // GET: Anime/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Anime/Delete/5
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
    }
}
