using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using project05.Models;

namespace project05.Controllers
{
    public class BugController : Controller
    {
        // GET: Bug
        public ActionResult Index()
        {
            List<Bug> bugs = new List<Bug>();

            bugs.Add(new Bug { Id = 1, Title = "Broken Keybopard", Description = "The keyboard is cracked in half" });
            bugs.Add(new Bug { Id = 2, Title = "Blank Monitor", Description = "The monitor won't display anything" });
            bugs.Add(new Bug { Id = 3, Title = "Bad Power Supply", Description = "The computer won't turn on" });



            Session["bugs"] = bugs;
            return View(bugs);
        }

        // GET: Bug/Details/5
        public ActionResult Details(int id)
        {
            List<Bug> bugs;

            bugs = (List<Bug> )Session["bugs"];

            Bug bug = bugs.Where(p => p.Id == id).Single();


            return View(bug);
        }

        // GET: Bug/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bug/Create
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

        // GET: Bug/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bug/Edit/5
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

        // GET: Bug/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bug/Delete/5
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
