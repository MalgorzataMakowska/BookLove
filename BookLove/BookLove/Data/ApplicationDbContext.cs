using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookLove.Models;

namespace BookLove.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BookLove.Models.BookGenre> BookGenre { get; set; } = default!;
        public DbSet<BookLove.Models.Book> Book { get; set; } = default!;
        public DbSet<BookLove.Models.FavouriteBook> FavouriteBook { get; set; } = default!;
        public DbSet<BookLove.Models.Review> Review { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Dodaj stałe gatunki przy tworzeniu bazy danych
            modelBuilder.Entity<BookGenre>().HasData(
                new BookGenre { Id = 1, Name = "Fantastyka" },
                new BookGenre { Id = 2, Name = "Literatura obyczajowa" },
                new BookGenre { Id = 3, Name = "Literatura naukowa" },
                new BookGenre { Id = 4, Name = "Kryminał" },
                new BookGenre { Id = 5, Name = "Thriller" }
            );

            // Dodaj początkowe dane kilku popularnych książek
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Władca Pierścieni", Author = "J.R.R. Tolkien", Language = "Polski", BookGenreId = 1, Description = "Epicka powieść fantasy" },
                new Book { Id = 2, Title = "Czekolada z chili", Author = "Laura Esquivel", Language = "Polski", BookGenreId = 2, Description = "Romans z nutką magii" },
                new Book { Id = 3, Title = "Kosmos", Author = "Carl Sagan", Language = "Polski", BookGenreId = 3, Description = "Popularnonaukowe spojrzenie na wszechświat" },
                new Book { Id = 4, Title = "Złodziejka książek", Author = "Markus Zusak", Language = "Polski", BookGenreId = 4, Description = "Historia narracji z perspektywy śmierci" },
                new Book { Id = 5, Title = "Milcząca owca", Author = "Thomas Harris", Language = "Polski", BookGenreId = 5, Description = "Klasyczny thriller psychologiczny" },
                new Book { Id = 6, Title = "Ostatnie życzenie", Author = "Andrzej Sapkowski", Language = "Polski", BookGenreId = 1, Description = "niezwykłe i wciągające opowieści o przygodach wiedźmina Geralta z Rivii" },
                new Book { Id = 7, Title = "Pamiętnik", Author = "Nicholas Sparks", Language = "Polski", BookGenreId = 2, Description = "Piękna i wzruszająca opowieść o wielkiej miłości,która potrafiła przetrwać przez czternaście lat w rozłące" },
                new Book { Id = 8, Title = "Kosmiczne zachwyty i rozterki", Author = "Neil deGrasse Tyson", Language = "Polski", BookGenreId = 3, Description = "Te opowieści o wszechświecie rozpalą waszą wyobraźnię" },
                new Book { Id = 9, Title = "Morderstwo w Orient Expressie", Author = "Agatha Christie", Language = "Polski", BookGenreId = 4, Description = "klasyczna powieść kryminalna autorstwa Agathy Christie, w której słynny detektyw Hercule Poirot prowadzi śledztwo w zamkniętym przedziałowym pociągu Orient Express, starając się rozwikłać tajemnicze morderstwo jednego z pasażerów" },
                new Book { Id = 10, Title = "Nocny dom", Author = "Jo Nesbo", Language = "Polski", BookGenreId = 5, Description = "powieść, w której świat realny miesza się z fikcyjnym" },
                new Book { Id = 11, Title = "Kolor magii", Author = "Terry Pratchett", Language = "Polski", BookGenreId = 1, Description = "Pierwsza część długiego cyklu Świat Dysku" },
                new Book { Id = 12, Title = "Diabeł ubiera się u Prady", Author = "Lauren Weisberger", Language = "Polski", BookGenreId = 2, Description = "porywająca powieść, która rzuca spojrzenie za kulisy światka mody w Nowym Jorku" },
                new Book { Id = 13, Title = "Krótka historia czasu ", Author = "Stephen Hawking", Language = "Polski", BookGenreId = 3, Description = " Poznaj ogrom przestrzeni międzygalaktycznej i znajdź odpowiedzi na pytania o czasoprzestrzeń" },
                new Book { Id = 14, Title = "Zemsta", Author = "Jo Nesbo", Language = "Polski", BookGenreId = 4, Description = "Autor z wirtuozerią odmalowuje mroczne wizje przyszłości, w których sprawiedliwość rządzi się swoimi zasadami" },
                new Book { Id = 15, Title = "Kasacja", Author = "Remigiusz Mróz", Language = "Polski", BookGenreId = 5, Description = "Polski thriller prawniczy" }
            );
        }
    }
}