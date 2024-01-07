using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLove.Data.Migrations
{
    /// <inheritdoc />
    public partial class favourites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SessionId",
                table: "FavouriteBook",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "FavouriteBook");
        }
    }
}
