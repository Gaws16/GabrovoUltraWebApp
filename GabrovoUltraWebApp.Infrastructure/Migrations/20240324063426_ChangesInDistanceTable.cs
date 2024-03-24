using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInDistanceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distances_Races_RaceId",
                table: "Distances");

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "Distances",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "ForeignKey to Race table");

            migrationBuilder.AddForeignKey(
                name: "FK_Distances_Races_RaceId",
                table: "Distances",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distances_Races_RaceId",
                table: "Distances");

            migrationBuilder.AlterColumn<int>(
                name: "RaceId",
                table: "Distances",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "ForeignKey to Race table",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Distances_Races_RaceId",
                table: "Distances",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
