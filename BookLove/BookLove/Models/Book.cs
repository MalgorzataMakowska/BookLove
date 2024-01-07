namespace BookLove.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public int BookGenreId { get; set; }
        public virtual BookGenre? BookGenre { get; set; }
        public string Description { get; set; }
        public bool IsFavourite { get; set; }
    }
}
