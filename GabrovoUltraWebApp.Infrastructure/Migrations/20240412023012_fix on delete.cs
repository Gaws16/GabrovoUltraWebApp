using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixondelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Registrations_RegistrationId",
                table: "Results");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Registrations_RegistrationId",
                table: "Results",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Registrations_RegistrationId",
                table: "Results");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Registrations_RegistrationId",
                table: "Results",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
