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
using BookLove.Data.Migrations;

namespace BookLove.Controllers
{
    [Authorize]
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ReviewsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        
        // GET: Reviews
        public async Task<IActionResult> Index()
        {
            IdentityUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var applicationDbContext = _context.Review.Include(r => r.Book).Include(s=>s.user).Where(p => p.userId == user.Id);
            return View(await applicationDbContext.ToListAsync());
        }
        
        // GET: Reviews/Create
        public IActionResult Create()
        {
            // Pobierz ID użytkownika aktualnie zalogowanego
            var userId = _userManager.GetUserId(User);

            // Pobierz listę ID książek, do których użytkownik już dodał opinie
            var reviewedBookIds = _context.Review
                .Where(r => r.userId == userId)
                .Select(r => r.BookId)
                .ToList();

            // Pobierz listę książek, do których użytkownik jeszcze nie dodał opinii
            var booksWithoutReview = _context.Book
                .Where(b => !reviewedBookIds.Contains(b.Id))
                .ToList();

            ViewData["BookId"] = new SelectList(booksWithoutReview, "Id", "Title");
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BookId,Grade,Description")] Review review)
        {
            // Pobierz ID użytkownika aktualnie zalogowanego
            var userId = _userManager.GetUserId(User);

            review.userId = userId;

            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Pobierz ponownie listę ID książek, do których użytkownik już dodał opinie
            var reviewedBookIds = _context.Review
                .Where(r => r.userId == userId)
                .Select(r => r.BookId)
                .ToList();

            // Pobierz listę książek, do których użytkownik jeszcze nie dodał opinii
            var booksWithoutReview = _context.Book
                .Where(b => !reviewedBookIds.Contains(b.Id))
                .ToList();

            ViewData["BookId"] = new SelectList(booksWithoutReview, "Id", "Title", review.BookId);
            return View(review);
        }

        // GET: Reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            // Pobierz ID użytkownika aktualnie zalogowanego
            var userId = _userManager.GetUserId(User);

            // Sprawdź, czy użytkownik ma uprawnienia do edycji recenzji
            if (review.userId != userId)
            {
                return Forbid(); 
            }

            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Title", review.BookId);
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BookId,Grade,Description")] Review review)
        {
            if (id != review.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.Id))
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
            ViewData["BookId"] = new SelectList(_context.Book, "Id", "Title", review.BookId);
            return View(review);
        }
        
        // GET: Reviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Review == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .Include(r => r.Book)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            return View(review);
        }
        
        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Review == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Review'  is null.");
            }
            var review = await _context.Review.FindAsync(id);
            if (review != null)
            {
                _context.Review.Remove(review);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
          return (_context.Review?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
