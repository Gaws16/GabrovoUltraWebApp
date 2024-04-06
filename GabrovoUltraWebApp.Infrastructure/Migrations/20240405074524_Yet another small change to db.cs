using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Yetanothersmallchangetodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Distances_Registrations_RegistrationId",
                table: "Distances");

            migrationBuilder.DropIndex(
                name: "IX_Distances_RegistrationId",
                table: "Distances");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "Distances");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_DistanceId",
                table: "Registrations",
                column: "DistanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Distances_DistanceId",
                table: "Registrations",
                column: "DistanceId",
                principalTable: "Distances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Distances_DistanceId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_DistanceId",
                table: "Registrations");

            migrationBuilder.AddColumn<int>(
                name: "RegistrationId",
                table: "Distances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Distances_RegistrationId",
                table: "Distances",
                column: "RegistrationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Distances_Registrations_RegistrationId",
                table: "Distances",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "RegistrationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
