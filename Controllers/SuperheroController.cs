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
            return View();
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
            var editing = _context.Superheroes.Where(e => e.SuperheroId == id).FirstOrDefault();
            return View(editing);
        }

        // POST: SuperheroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                var duperhero = _context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
                _context.Superheroes.Remove(duperhero);
                _context.Superheroes.Add(superhero);
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
            var duperhero = _context.Superheroes.Where(s => s.SuperheroId == id).FirstOrDefault();
            _context.Superheroes.Remove(duperhero);
            _context.SaveChanges();
            return View();
        }

        // POST: SuperheroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
