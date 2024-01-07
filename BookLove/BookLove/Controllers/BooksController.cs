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
using Microsoft.AspNetCore.Identity;

namespace BookLove.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public BooksController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Books
        public IActionResult Index()
        {
            var books = _context.Book.Include(b => b.BookGenre).ToList();
            var averageRatings = new Dictionary<int, double>();

            // Sprawdzenie, czy użytkownik jest zalogowany
            var user = _userManager.GetUserAsync(User).Result;
            var favouriteBookIds = user != null
                ? _context.FavouriteBook
                    .Where(fb => fb.userId == user.Id)
                    .Select(fb => fb.BookId)
                    .ToList()
                : new List<int>();

            foreach (var book in books)
                {
                    var reviews = _context.Review.Where(r => r.BookId == book.Id).ToList();
                    averageRatings[book.Id] = reviews.Any() ? reviews.Average(r => r.Grade) : 0;

                    // Sprawdzenie, czy książka jest ulubiona (dla zalogowanego użytkownika)
                    if (user != null)
                    {
                        ViewData["IsFavourite_" + book.Id] = favouriteBookIds.Contains(book.Id);
                    }
                    else
                    {
                        // Ustawienie, że niezalogowany użytkownik nie ma ulubionych książek
                        ViewData["IsFavourite_" + book.Id] = false;
                    }
                }
                ViewData["AverageRatings"] = averageRatings;
                return View(books);
            }

            // GET: Books/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.BookGenre)
                .FirstOrDefaultAsync(m => m.Id == id);

            var reviews = await _context.Review
                .Where(r => r.BookId == id)
                .ToListAsync();

            if (book == null)
            {
                return NotFound();
            }

            ViewData["Reviews"] = reviews; 

            //obliczanie średniej oceny książki
            double averageRating = reviews.Any() ? reviews.Average(r => r.Grade) : 0;
            ViewData["AverageRating"] = averageRating;

            return View(book);
        }

        // GET: Books/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["BookGenreId"] = new SelectList(_context.BookGenre, "Id", "Name");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id,Title,Author,Language,BookGenreId,Description")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookGenreId"] = new SelectList(_context.BookGenre, "Id", "Name", book.BookGenreId);
            return View(book);
        }

        // GET: Books/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["BookGenreId"] = new SelectList(_context.BookGenre, "Id", "Name", book.BookGenreId);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Author,Language,BookGenreId,Description")] Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookGenreId"] = new SelectList(_context.BookGenre, "Id", "Name", book.BookGenreId);
            return View(book);
        }

        // GET: Books/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .Include(b => b.BookGenre)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Book == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Book'  is null.");
            }
            var book = await _context.Book.FindAsync(id);
            if (book != null)
            {
                _context.Book.Remove(book);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
          return (_context.Book?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
