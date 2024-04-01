using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Addnavpropertytoregistrationfixcascades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Categories_CategoryId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Distances_DistanceId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Races_RaceId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Races_RaceId1",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Registrations_RegistrationId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_CategoryId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_DistanceId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_RaceId1",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "RaceId1",
                table: "Registrations");

            migrationBuilder.AddColumn<int>(
                name: "RegistrationId",
                table: "Distances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RegistrationId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Distances_RegistrationId",
                table: "Distances",
                column: "RegistrationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_RegistrationId",
                table: "Categories",
                column: "RegistrationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Registrations_RegistrationId",
                table: "Categories",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "RegistrationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Distances_Registrations_RegistrationId",
                table: "Distances",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "RegistrationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Races_RaceId",
                table: "Registrations",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Registrations_RegistrationId",
                table: "Results",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "RegistrationId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Registrations_RegistrationId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Distances_Registrations_RegistrationId",
                table: "Distances");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Races_RaceId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Registrations_RegistrationId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Distances_RegistrationId",
                table: "Distances");

            migrationBuilder.DropIndex(
                name: "IX_Categories_RegistrationId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "Distances");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "RaceId1",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CategoryId",
                table: "Registrations",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_DistanceId",
                table: "Registrations",
                column: "DistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_RaceId1",
                table: "Registrations",
                column: "RaceId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Categories_CategoryId",
                table: "Registrations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Distances_DistanceId",
                table: "Registrations",
                column: "DistanceId",
                principalTable: "Distances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Races_RaceId",
                table: "Registrations",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Races_RaceId1",
                table: "Registrations",
                column: "RaceId1",
                principalTable: "Races",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Registrations_RegistrationId",
                table: "Results",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "RegistrationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
