using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookLove.Data.Migrations
{
    /// <inheritdoc />
    public partial class newbooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Andrzej Sapkowski", "niezwykłe i wciągające opowieści o przygodach wiedźmina Geralta z Rivii", "Ostatnie życzenie" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Nicholas Sparks", "Piękna i wzruszająca opowieść o wielkiej miłości,która potrafiła przetrwać przez czternaście lat w rozłące", "Pamiętnik" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Neil deGrasse Tyson", "Te opowieści o wszechświecie rozpalą waszą wyobraźnię", "Kosmiczne zachwyty i rozterki" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Agatha Christie", "klasyczna powieść kryminalna autorstwa Agathy Christie, w której słynny detektyw Hercule Poirot prowadzi śledztwo w zamkniętym przedziałowym pociągu Orient Express, starając się rozwikłać tajemnicze morderstwo jednego z pasażerów", "Morderstwo w Orient Expressie" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Jo Nesbo", "powieść, w której świat realny miesza się z fikcyjnym", "Nocny dom" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Terry Pratchett", "Pierwsza część długiego cyklu Świat Dysku", "Kolor magii" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Lauren Weisberger", "porywająca powieść, która rzuca spojrzenie za kulisy światka mody w Nowym Jorku", "Diabeł ubiera się u Prady" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Stephen Hawking", " Poznaj ogrom przestrzeni międzygalaktycznej i znajdź odpowiedzi na pytania o czasoprzestrzeń", "Krótka historia czasu " });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Jo Nesbo", "Autor z wirtuozerią odmalowuje mroczne wizje przyszłości, w których sprawiedliwość rządzi się swoimi zasadami", "Zemsta" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Remigiusz Mróz", "Polski thriller prawniczy", "Kasacja" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "J.R.R. Tolkien", "Epicka powieść fantasy", "Władca Pierścieni" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Laura Esquivel", "Romans z nutką magii", "Czekolada z chili" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Carl Sagan", "Popularnonaukowe spojrzenie na wszechświat", "Kosmos" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Markus Zusak", "Historia narracji z perspektywy śmierci", "Złodziejka książek" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Thomas Harris", "Klasyczny thriller psychologiczny", "Milcząca owca" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "J.R.R. Tolkien", "Epicka powieść fantasy", "Władca Pierścieni" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Laura Esquivel", "Romans z nutką magii", "Czekolada z chili" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Carl Sagan", "Popularnonaukowe spojrzenie na wszechświat", "Kosmos" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Markus Zusak", "Historia narracji z perspektywy śmierci", "Złodziejka książek" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Description", "Title" },
                values: new object[] { "Thomas Harris", "Klasyczny thriller psychologiczny", "Milcząca owca" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "BookGenreId", "Description", "Language", "Title" },
                values: new object[,]
                {
                    { 16, "J.R.R. Tolkien", 1, "Epicka powieść fantasy", "Polski", "Władca Pierścieni" },
                    { 17, "Laura Esquivel", 2, "Romans z nutką magii", "Polski", "Czekolada z chili" },
                    { 18, "Carl Sagan", 3, "Popularnonaukowe spojrzenie na wszechświat", "Polski", "Kosmos" },
                    { 19, "Markus Zusak", 4, "Historia narracji z perspektywy śmierci", "Polski", "Złodziejka książek" },
                    { 20, "Thomas Harris", 5, "Klasyczny thriller psychologiczny", "Polski", "Milcząca owca" }
                });
        }
    }
}
