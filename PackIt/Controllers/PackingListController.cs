using System;
using System.Collections.Generic;
using PackIt.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PackIt.Controllers
{
    public class PackingListController : Controller
    {
        PackItDB _db = new PackItDB();

        // GET: PackingList
        public ActionResult Index()
        {
            var model = _db.PackingLists.ToList();
            return View(model);
        }

        // GET: PackingList/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PackingList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PackingList/Create
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

        // GET: PackingList/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PackingList/Edit/5
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

        // GET: PackingList/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PackingList/Delete/5
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
