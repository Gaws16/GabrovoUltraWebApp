using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class testuserseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "City", "ConcurrencyStamp", "Country", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationId", "SecurityStamp", "Team", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36", 0, 0, "Gabrovo", "8a496c9b-92dc-4331-84f5-abce095c2a25", "Bulgaria", "ApplicationUser", "pesho@gabrovoutra.bg", false, "Pesho", 0, "Peshov", false, null, "PESHO@GABROVOULTRA.BG", "PESHO@GABROVOULTRA.BG", "AQAAAAIAAYagAAAAEL/P2ByDhKeyVxMlAsIPq15kUhdolHlYfaIt45Vh8ZSxM406tph1Z1nv/wudMBrM3Q==", null, false, null, "53881894-11c7-4c4c-9817-d5db5a6d1968", null, false, "pesho@gabrovoutra.bg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36");
        }
    }
}
