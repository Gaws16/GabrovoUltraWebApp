using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Results_RaceId",
                table: "Results",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Races_RaceId",
                table: "Results",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Races_RaceId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_RaceId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Results");
        }
    }
}
