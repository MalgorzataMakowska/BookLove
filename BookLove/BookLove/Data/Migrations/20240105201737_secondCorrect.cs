using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLove.Data.Migrations
{
    /// <inheritdoc />
    public partial class secondCorrect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookGenre_BookGenreId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "BookGenereId",
                table: "Book");

            migrationBuilder.AlterColumn<int>(
                name: "BookGenreId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookGenre_BookGenreId",
                table: "Book",
                column: "BookGenreId",
                principalTable: "BookGenre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookGenre_BookGenreId",
                table: "Book");

            migrationBuilder.AlterColumn<int>(
                name: "BookGenreId",
                table: "Book",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BookGenereId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookGenre_BookGenreId",
                table: "Book",
                column: "BookGenreId",
                principalTable: "BookGenre",
                principalColumn: "Id");
        }
    }
}
