using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCPrimerEjemplo.Data;
using MVCPrimerEjemplo.Models;

namespace MVCPrimerEjemplo.Controllers
{
    public class CinemasController : Controller
    {

        private readonly MVCPrimerEjemploContext _context;

        public CinemasController(MVCPrimerEjemploContext context)
        {
            _context = context;
        }



        // GET: Movies
        public async Task<IActionResult> Cinemas()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Cinema
                                            orderby m.Name
                                            select m.Name;

            var cinemas = from m in _context.Cinema
                         select m;

            //if (!string.IsNullOrEmpty(searchString))
            //{
            //    cinemas = cinemas.Where(s => s.Name!.Contains(searchString));
            //}

            //if (!string.IsNullOrEmpty(movieGenre))
            //{
            //    cinemas = cinemas.Where(x => x.Genre == movieGenre);
            //}

            var cinemaVM = new CinemaViewModel
            {
                Name = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Cinemas = await cinemas.ToListAsync()
            };

            return View(cinemaVM);
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,NumbertOfRooms,Price")] Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cinema);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Cinemas));
            }
            return View(cinema);
        }
    }
}
