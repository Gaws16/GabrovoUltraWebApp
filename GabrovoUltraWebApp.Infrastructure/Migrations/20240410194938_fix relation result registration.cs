using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixrelationresultregistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Registrations_RegistrationId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_RegistrationId",
                table: "Results");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ResultId",
                table: "Registrations",
                column: "ResultId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Results_ResultId",
                table: "Registrations",
                column: "ResultId",
                principalTable: "Results",
                principalColumn: "ResultId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Results_ResultId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_ResultId",
                table: "Registrations");

            migrationBuilder.CreateIndex(
                name: "IX_Results_RegistrationId",
                table: "Results",
                column: "RegistrationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Registrations_RegistrationId",
                table: "Results",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "RegistrationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
