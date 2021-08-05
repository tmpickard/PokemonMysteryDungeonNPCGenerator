using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PokemonMysteryDungeonNPCGenerator.Data;
using PokemonMysteryDungeonNPCGenerator.Models;

namespace PokemonMysteryDungeonNPCGenerator.Controllers
{
    public class PokemonController : Controller
    {
        private PokemonMysteryDungeonNPCGeneratorContext db = new PokemonMysteryDungeonNPCGeneratorContext();

        // GET: Pokemon
        public ActionResult Index()
        {
            return View(db.Pokemons.ToList());
        }

        // GET: Pokemon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pokemon pokemon = db.Pokemons.Find(id);
            if (pokemon == null)
            {
                return HttpNotFound();
            }
            return View(pokemon);
        }

        // GET: Pokemon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pokemon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PokemonId,Species,Image,Level,Gender,Nature,IsShiny,Type1,Type2,HPSpecies,AttSpecies,DefSpecies,SPAttSpecies,SPDefSpecies,SpdSpecies,HPTotal,AttTotal,DefTotal,SPAttTotal,SPDefTotal,SpdTotal,Overland,Sky,Swim,Levitate,Burrow,HighJump,LongJump,Power,Size,Weight,Acrobatics,Athletics,Charm,Combat,Command,GenEd,MedEd,OccEd,PokeEd,TechEd,Focus,Guile,Intimidate,Intuition,Perception,Stealth,Survival")] Pokemon pokemon)
        {
            if (ModelState.IsValid)
            {
                db.Pokemons.Add(pokemon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pokemon);
        }

        // GET: Pokemon/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pokemon pokemon = db.Pokemons.Find(id);
            if (pokemon == null)
            {
                return HttpNotFound();
            }
            return View(pokemon);
        }

        // POST: Pokemon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PokemonId,Species,Image,Level,Gender,Nature,IsShiny,Type1,Type2,HPSpecies,AttSpecies,DefSpecies,SPAttSpecies,SPDefSpecies,SpdSpecies,HPTotal,AttTotal,DefTotal,SPAttTotal,SPDefTotal,SpdTotal,Overland,Sky,Swim,Levitate,Burrow,HighJump,LongJump,Power,Size,Weight,Acrobatics,Athletics,Charm,Combat,Command,GenEd,MedEd,OccEd,PokeEd,TechEd,Focus,Guile,Intimidate,Intuition,Perception,Stealth,Survival")] Pokemon pokemon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pokemon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pokemon);
        }

        // GET: Pokemon/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pokemon pokemon = db.Pokemons.Find(id);
            if (pokemon == null)
            {
                return HttpNotFound();
            }
            return View(pokemon);
        }

        // POST: Pokemon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pokemon pokemon = db.Pokemons.Find(id);
            db.Pokemons.Remove(pokemon);
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
