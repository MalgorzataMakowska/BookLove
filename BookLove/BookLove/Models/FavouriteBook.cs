using Microsoft.AspNetCore.Identity;

namespace BookLove.Models
{
    public class FavouriteBook
    {
        public int Id { get; set; }
        public string? userId { get; set; }
        public virtual IdentityUser? user { get; set; }
        public int BookId { get; set; }
        public virtual Book? Book { get; set; }

    }
}
