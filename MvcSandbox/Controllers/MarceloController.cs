using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcSandbox.Controllers
{
    public class MarceloController : Controller
    {
        // GET: Marcelo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Marcelo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Marcelo/Create
        [Route("Maaa/SaveLocation")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marcelo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Marcelo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Marcelo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Marcelo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Marcelo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}