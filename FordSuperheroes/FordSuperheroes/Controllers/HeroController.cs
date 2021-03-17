using FordSuperheroes.Data;
using FordSuperheroes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FordSuperheroes.Controllers
{
    public class HeroController : Controller
    {
        private ApplicationDbContext _context;
        public HeroController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: HeroController
        public ActionResult HeroIndex()
        {
            var heroes = _context.Superhero;
            return View(heroes);
        }

        // GET: HeroController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HeroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HeroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hero hero)
        {
            try
            {
                _context.Superhero.Add(hero);
                _context.SaveChanges();
                return RedirectToAction("HeroIndex");
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: HeroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HeroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hero hero)
        {
            try
            {
                _context.Superhero.Remove(hero);
                _context.Superhero.Add(hero);
                _context.SaveChanges();
                return RedirectToAction("HeroIndex");
            }
            catch
            {
                return View();
            }
        }

        // GET: HeroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HeroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Hero hero)
        {
            try
            {
                _context.Superhero.Remove(hero);
                _context.SaveChanges();
                return RedirectToAction("HeroIndex");
            }
            catch
            {
                return View();
            }
        }
    }
}
