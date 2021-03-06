﻿using System;
using System.Linq;
using System.Web.Mvc;
using PghTechFest.Www.Models.Domain;
using PghTechFest.Www.Models;

namespace PghTechFest.Www.Controllers
{
    public class CallForSpeakersController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: /CallForSpeakers/Create
        public ActionResult Index()
        {
            //ViewBag.Tracks = db.Tracks;
            //return View("Create");
            return View("Closed");
        }

        // GET: /CallForSpeakers/Create
        public ActionResult Create()
        {
            ViewBag.Tracks = db.Tracks;
            return View();
        }

        // POST: /CallForSpeakers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Session session)
        {
            if (ModelState.IsValid)
            {
                session.Tracks = ModelState["Tracks"].Value.AttemptedValue;
                db.Sessions.Add(session);
                db.SaveChanges();
                return RedirectToAction("thanks");
            }

            ViewBag.Tracks = db.Tracks;
            return View(session);
        }

        public ActionResult Thanks()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
