using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlashCards.Data.Models;
using FlashCards.DAL;

namespace FlashCards.Controllers
{
    public class CardDecksController : Controller
    {
        private FlashCardsContext db = new FlashCardsContext();

        // GET: CardDecks
        public ActionResult Index()
        {
            return View(db.CardDecks.ToList());
        }

        // GET: CardDecks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardDeck cardDeck = db.CardDecks.Find(id);
            if (cardDeck == null)
            {
                return HttpNotFound();
            }
            return View(cardDeck);
        }

        // GET: CardDecks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CardDecks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,DateCreated")] CardDeck cardDeck)
        {
            if (ModelState.IsValid)
            {
                db.CardDecks.Add(cardDeck);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cardDeck);
        }

        // GET: CardDecks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardDeck cardDeck = db.CardDecks.Find(id);
            if (cardDeck == null)
            {
                return HttpNotFound();
            }
            return View(cardDeck);
        }

        // POST: CardDecks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,DateCreated")] CardDeck cardDeck)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cardDeck).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cardDeck);
        }

        // GET: CardDecks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CardDeck cardDeck = db.CardDecks.Find(id);
            if (cardDeck == null)
            {
                return HttpNotFound();
            }
            return View(cardDeck);
        }

        // POST: CardDecks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CardDeck cardDeck = db.CardDecks.Find(id);
            db.CardDecks.Remove(cardDeck);
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
    }
}
