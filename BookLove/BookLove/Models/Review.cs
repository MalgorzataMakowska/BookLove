using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookLove.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string? userId { get; set; }
        public virtual IdentityUser? user { get; set; }
        public int BookId {  get; set; }
        public virtual Book? Book { get; set; }

        [Range(1, 5, ErrorMessage = "Ocena musi się mieścić między 1 a 5.")]
        public int Grade { get; set; }  
        public string Description { get; set; }
    }
}
