using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookLove.Data;
using BookLove.Models;
using Microsoft.AspNetCore.Authorization;

namespace BookLove.Controllers
{
    public class BookGenresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookGenresController(ApplicationDbContext context)
        {
            _context = context;
        }

        //wyszukanie ksiazek z danego gatunku
        public IActionResult BooksByGenre(int id)
        {
            var booksInGenre = _context.Book.Where(b => b.BookGenreId == id).ToList();
            var genreName = _context.BookGenre.Where(g => g.Id == id).Select(g => g.Name).FirstOrDefault();
            ViewBag.GenreName = genreName;
            return View(booksInGenre);
        }

        // GET: BookGenres
        public async Task<IActionResult> Index()
        {
              return _context.BookGenre != null ? 
                          View(await _context.BookGenre.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.BookGenre'  is null.");
        }


        // GET: BookGenres/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookGenres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id,Name")] BookGenre bookGenre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookGenre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookGenre);
        }

    }
}
