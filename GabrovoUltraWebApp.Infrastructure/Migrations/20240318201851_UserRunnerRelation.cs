using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserRunnerRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Runners",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Runners_UserId",
                table: "Runners",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Runners_AspNetUsers_UserId",
                table: "Runners",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Runners_AspNetUsers_UserId",
                table: "Runners");

            migrationBuilder.DropIndex(
                name: "IX_Runners_UserId",
                table: "Runners");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Runners");
        }
    }
}
