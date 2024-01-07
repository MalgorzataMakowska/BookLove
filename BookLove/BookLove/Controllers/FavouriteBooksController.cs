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
    [Authorize]
    public class FavouriteBooksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public FavouriteBooksController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            
        }
        //dodanie do ulubionych
        [HttpPost]
        public async Task<IActionResult> AddToFavourites(int bookId)
        {
            var book = await _context.Book.FindAsync(bookId);

            if (book != null)
            {
                // Sprawdź, czy ta książka już istnieje w ulubionych dla aktualnie zalogowanego użytkownika
                var user = await _userManager.GetUserAsync(User);
                var existingFavourite = await _context.FavouriteBook
                    .FirstOrDefaultAsync(fb => fb.BookId == bookId && fb.userId == user.Id);

                if (existingFavourite == null)
                {
                    var favouriteBook = new FavouriteBook
                    {
                        Book = book,
                        userId = user.Id
                    };

                    _context.FavouriteBook.Add(favouriteBook);
                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Książka została dodana do ulubionych. Odśwież stronę" });
                }
                else
                {
                    // Książka już istnieje w ulubionych
                    return Json(new { success = false, message = "Ta książka już znajduje się w ulubionych." });
                }
            }
            else
            {
                // Nie można znaleźć książki
                return Json(new { success = false, message = "Nie można znaleźć książki." });
            }
        }
        // GET: FavouriteBooks
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IdentityUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            var favouriteBooks = await _context.FavouriteBook.Include(fb => fb.Book).ThenInclude(b => b.BookGenre).Include(f => f.user).Where(p => p.userId == user.Id).ToListAsync();
            return View(favouriteBooks);
        }


        // GET: FavouriteBooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favouriteBook = await _context.FavouriteBook
                .Include(fb => fb.Book)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (favouriteBook == null)
            {
                return NotFound();
            }

            return View(favouriteBook);
        }

        // GET: FavouriteBooks/Create
        public async Task<IActionResult> Create()
        {
            // Pobierz ID użytkownika aktualnie zalogowanego
            IdentityUser user = await _userManager.GetUserAsync(User);
            var userId = user.Id;

            // Pobierz listę ID ulubionych książek tego użytkownika
            var favouriteBookIds = await _context.FavouriteBook
                .Where(fb => fb.userId == userId)
                .Select(fb => fb.BookId)
                .ToListAsync();

            // Pobierz listę książek, które nie są jeszcze ulubione
            var books = await _context.Book
                .Where(b => !favouriteBookIds.Contains(b.Id))
                .ToListAsync();

            ViewData["BookId"] = new SelectList(books, "Id", "Title");
            return View();
        }

        // POST: FavouriteBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookId")] FavouriteBook favouriteBook)
        {
            IdentityUser user = await _userManager.GetUserAsync(User);
            favouriteBook.userId = user.Id;

            if (ModelState.IsValid)
            {
                _context.Add(favouriteBook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Pobierz listę książek, które nie są jeszcze ulubione
            var books = await _context.Book
                .Where(b => b.Id != favouriteBook.BookId)
                .ToListAsync();

            ViewData["BookId"] = new SelectList(books, "Id", "Title", favouriteBook.BookId);
            return View(favouriteBook);
        }

        // GET: FavouriteBooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FavouriteBook == null)
            {
                return NotFound();
            }

            var favouriteBook = await _context.FavouriteBook
                .Include(f => f.Book)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favouriteBook == null)
            {
                return NotFound();
            }

            return View(favouriteBook);
        }

        // POST: FavouriteBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FavouriteBook == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FavouriteBook'  is null.");
            }
            var favouriteBook = await _context.FavouriteBook.FindAsync(id);
            if (favouriteBook != null)
            {
                _context.FavouriteBook.Remove(favouriteBook);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FavouriteBookExists(int id)
        {
          return (_context.FavouriteBook?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
