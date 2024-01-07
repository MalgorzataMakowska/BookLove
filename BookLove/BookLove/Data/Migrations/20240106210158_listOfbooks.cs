using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookLove.Data.Migrations
{
    /// <inheritdoc />
    public partial class listOfbooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "BookGenreId", "Description", "Language", "Title" },
                values: new object[,]
                {
                    { 1, "J.R.R. Tolkien", 1, "Epicka powieść fantasy", "Polski", "Władca Pierścieni" },
                    { 2, "Laura Esquivel", 2, "Romans z nutką magii", "Polski", "Czekolada z chili" },
                    { 3, "Carl Sagan", 3, "Popularnonaukowe spojrzenie na wszechświat", "Polski", "Kosmos" },
                    { 4, "Markus Zusak", 4, "Historia narracji z perspektywy śmierci", "Polski", "Złodziejka książek" },
                    { 5, "Thomas Harris", 5, "Klasyczny thriller psychologiczny", "Polski", "Milcząca owca" },
                    { 6, "J.R.R. Tolkien", 1, "Epicka powieść fantasy", "Polski", "Władca Pierścieni" },
                    { 7, "Laura Esquivel", 2, "Romans z nutką magii", "Polski", "Czekolada z chili" },
                    { 8, "Carl Sagan", 3, "Popularnonaukowe spojrzenie na wszechświat", "Polski", "Kosmos" },
                    { 9, "Markus Zusak", 4, "Historia narracji z perspektywy śmierci", "Polski", "Złodziejka książek" },
                    { 10, "Thomas Harris", 5, "Klasyczny thriller psychologiczny", "Polski", "Milcząca owca" },
                    { 11, "J.R.R. Tolkien", 1, "Epicka powieść fantasy", "Polski", "Władca Pierścieni" },
                    { 12, "Laura Esquivel", 2, "Romans z nutką magii", "Polski", "Czekolada z chili" },
                    { 13, "Carl Sagan", 3, "Popularnonaukowe spojrzenie na wszechświat", "Polski", "Kosmos" },
                    { 14, "Markus Zusak", 4, "Historia narracji z perspektywy śmierci", "Polski", "Złodziejka książek" },
                    { 15, "Thomas Harris", 5, "Klasyczny thriller psychologiczny", "Polski", "Milcząca owca" },
                    { 16, "J.R.R. Tolkien", 1, "Epicka powieść fantasy", "Polski", "Władca Pierścieni" },
                    { 17, "Laura Esquivel", 2, "Romans z nutką magii", "Polski", "Czekolada z chili" },
                    { 18, "Carl Sagan", 3, "Popularnonaukowe spojrzenie na wszechświat", "Polski", "Kosmos" },
                    { 19, "Markus Zusak", 4, "Historia narracji z perspektywy śmierci", "Polski", "Złodziejka książek" },
                    { 20, "Thomas Harris", 5, "Klasyczny thriller psychologiczny", "Polski", "Milcząca owca" }
                });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Fantasyka");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15);

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
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Fantasy");
        }
    }
}
