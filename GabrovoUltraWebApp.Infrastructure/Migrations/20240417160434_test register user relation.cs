using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class testregisteruserrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0d307f6-d2ac-4ffa-af33-23f35cdd4dd8", "AQAAAAIAAYagAAAAEHxhUXXY/muQo4uqYg8YhklUDdwZAM40k7u7nTWYar6xRfWZr/y/j2OeVwhcmWZ3tw==", "3d013a08-3e3e-4aca-8354-d4b6be823e53" });

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 4, 33, 919, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DistanceId", "IsPaymentConfirmed", "RaceId", "RegistrationDate", "StartingNumber", "UserId" },
                values: new object[] { 13, 2, true, 1, new DateTime(2024, 4, 17, 19, 4, 33, 919, DateTimeKind.Local).AddTicks(7402), "7505", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "City", "ConcurrencyStamp", "Country", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationId", "SecurityStamp", "Team", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37", 0, 0, "Gabrovo", "5df07ce0-38dd-45f9-bbff-dcc81f1381c1", "Bulgaria", "ApplicationUser", "sasho@gabrovoultra.bg", false, "Sasho", 0, "Sashov", false, null, "SASHO@GABROVOULTRA>BG", "SASHO@GABROVOULTRA>BG", "AQAAAAIAAYagAAAAEB5xCjil7I5Au6nGNxwWmcfLaRx+ygbrgNJAjhtsATs8xn7fTbFy8uneT5YS1EJTHw==", null, false, 13, "5de0f7f3-54ae-4a1c-a089-807d15fbb475", null, false, "sasho@gabrovoultra.bg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37");

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6c76b41-c301-4a6f-9776-9365973e34a4", "AQAAAAIAAYagAAAAED3k8Jy18feDMMVsD5LB7WH+g8W8DeOrNMB/AN15wBErN+riBOZKF/ZWMXS1Awhokg==", "29d51084-fad7-421a-92e0-f3b4fcebe34b" });

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 1, 52, 169, DateTimeKind.Local).AddTicks(3358));
        }
    }
}
