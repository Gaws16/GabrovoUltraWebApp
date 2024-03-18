using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixRelations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Runners_Races_RaceId",
                table: "Runners");

            migrationBuilder.DropIndex(
                name: "IX_Runners_RaceId",
                table: "Runners");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Runners");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Runners",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Runners_RaceId",
                table: "Runners",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Runners_Races_RaceId",
                table: "Runners",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id");
        }
    }
}
