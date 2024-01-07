using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLove.Data.Migrations
{
    /// <inheritdoc />
    public partial class users2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "uerId",
                table: "FavouriteBook");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "uerId",
                table: "FavouriteBook",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
