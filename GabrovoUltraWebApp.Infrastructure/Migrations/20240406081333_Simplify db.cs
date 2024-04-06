using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Simplifydb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Registrations_RegistrationId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_RegistrationId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Registrations",
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
        }
    }
}
