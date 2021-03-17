using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Data;
using SuperHero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Controllers
{
    public class SuperheroController : Controller
    {
        private ApplicationDbContext _context;

        public SuperheroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperheroController
        public ActionResult Index()
        {
            var superhero = _context.Superheroes.ToList();
            return View(superhero);
        }

        // GET: SuperheroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperheroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperheroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                _context.Superheroes.Add(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Edit/5
        public ActionResult Edit(int id)
        {
            var superhero = _context.Superheroes.Where(e => e.SuperheroId == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: SuperheroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                
                _context.Superheroes.Update(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroController/Delete/5
        public ActionResult Delete(int id)
        {
            var superhero = _context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: SuperheroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                
                _context.Superheroes.Remove(superhero);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
