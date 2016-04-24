﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyCloset2.Models;
using MyClosetApp.Models;

namespace MyCloset2.Controllers
{
    public class BottomsController : Controller
    {
        private MyCloset2Context db = new MyCloset2Context();

        // GET: Bottoms
        public ActionResult Index()
        {
            return View(db.Bottoms.ToList());
        }

        // GET: Bottoms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bottoms bottoms = db.Bottoms.Find(id);
            if (bottoms == null)
            {
                return HttpNotFound();
            }
            return View(bottoms);
        }

        // GET: Bottoms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bottoms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BottomsID,Nickname,PhotoURL,Type,Color,Season,Occasion")] Bottoms bottoms)
        {
            if (ModelState.IsValid)
            {
                db.Bottoms.Add(bottoms);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bottoms);
        }

        // GET: Bottoms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bottoms bottoms = db.Bottoms.Find(id);
            if (bottoms == null)
            {
                return HttpNotFound();
            }
            return View(bottoms);
        }

        // POST: Bottoms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BottomsID,Nickname,PhotoURL,Type,Color,Season,Occasion")] Bottoms bottoms)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bottoms).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bottoms);
        }

        // GET: Bottoms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bottoms bottoms = db.Bottoms.Find(id);
            if (bottoms == null)
            {
                return HttpNotFound();
            }
            return View(bottoms);
        }

        // POST: Bottoms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bottoms bottoms = db.Bottoms.Find(id);
            db.Bottoms.Remove(bottoms);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Manager()
        {
            return View(db.Bottoms.ToList());
        }
    }
}
