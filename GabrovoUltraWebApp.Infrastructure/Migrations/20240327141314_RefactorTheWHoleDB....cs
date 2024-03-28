using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RefactorTheWHoleDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distances_Races_RaceId",
                table: "Distances");

            migrationBuilder.DropTable(
                name: "RaceRunner");

            migrationBuilder.DropIndex(
                name: "IX_Distances_RaceId",
                table: "Distances");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Runners");

            migrationBuilder.DropColumn(
                name: "RaceId",
                table: "Distances");

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistanceId = table.Column<int>(type: "int", nullable: false),
                    RunnerId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Distances_DistanceId",
                        column: x => x.DistanceId,
                        principalTable: "Distances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Results_Runners_RunnerId",
                        column: x => x.RunnerId,
                        principalTable: "Runners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_DistanceId",
                table: "Results",
                column: "DistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_RunnerId",
                table: "Results",
                column: "RunnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Runners",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Category of the runner");

            migrationBuilder.AddColumn<int>(
                name: "RaceId",
                table: "Distances",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RaceRunner",
                columns: table => new
                {
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    RunnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceRunner", x => new { x.RaceId, x.RunnerId });
                    table.ForeignKey(
                        name: "FK_RaceRunner_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceRunner_Runners_RunnerId",
                        column: x => x.RunnerId,
                        principalTable: "Runners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Distances_RaceId",
                table: "Distances",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_RaceRunner_RunnerId",
                table: "RaceRunner",
                column: "RunnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Distances_Races_RaceId",
                table: "Distances",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id");
        }
    }
}
