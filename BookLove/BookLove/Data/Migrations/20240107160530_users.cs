using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLove.Data.Migrations
{
    /// <inheritdoc />
    public partial class users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "uerId",
                table: "FavouriteBook",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "FavouriteBook",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteBook_userId",
                table: "FavouriteBook",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavouriteBook_AspNetUsers_userId",
                table: "FavouriteBook",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavouriteBook_AspNetUsers_userId",
                table: "FavouriteBook");

            migrationBuilder.DropIndex(
                name: "IX_FavouriteBook_userId",
                table: "FavouriteBook");

            migrationBuilder.DropColumn(
                name: "uerId",
                table: "FavouriteBook");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "FavouriteBook");
        }
    }
}
