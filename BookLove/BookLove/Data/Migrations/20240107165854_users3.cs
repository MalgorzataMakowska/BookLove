using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLove.Data.Migrations
{
    /// <inheritdoc />
    public partial class users3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Review",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_userId",
                table: "Review",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_userId",
                table: "Review",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_userId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_userId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Review");
        }
    }
}
