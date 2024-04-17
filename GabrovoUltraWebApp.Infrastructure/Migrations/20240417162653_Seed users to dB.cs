using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeeduserstodB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "80908387-bbd3-404f-a019-90f77d87adf8", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "040c6515-044d-4773-85f7-6ba637a3b61f", "AQAAAAIAAYagAAAAECi9wxfGrku4b1y5r4WobR+Vz9paMf6xDXFnJfVFmXdgkbb0Ekfi9A3QUx/aX2KPeQ==", "a96f660b-821b-4c0b-9411-6870f6a10282" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7523cb2-b34d-4454-962f-32f4755d8abf", "AQAAAAIAAYagAAAAEFjm3zlIGZRQYXwdRVNfTpwH1ZuvruLDADrUA51velFK5I0tZe7XNuX5F+uQM7LpTw==", "273229c7-29ba-45ed-a81b-4ae261c4e25e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "City", "ConcurrencyStamp", "Country", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationId", "SecurityStamp", "Team", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f40", 0, 0, "Adminovgrad", "e73e925c-8676-42f6-9f6f-b246b2ec42db", "Bulgaria", "ApplicationUser", "admin@gabrovoultra.bg", false, "Admin", 0, "Adminov", false, null, "ADMIN@GABROVOULTRA.BG", "ADMIN@GABROVOULTRA.BG", "AQAAAAIAAYagAAAAEHomL7Qqz/TFyAm56YGcxUEdXSgPOCLyZRuhUkEnSRHEPYJpufeDVdStN7fhC0cpvQ==", null, false, null, "36c8e73c-36bc-4041-9dd0-f5941b94200f", null, false, "admin@gabrovoultra.bg" });

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 26, 52, 140, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 26, 52, 140, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DistanceId", "IsPaymentConfirmed", "RaceId", "RegistrationDate", "StartingNumber", "UserId" },
                values: new object[,]
                {
                    { 14, 2, true, 1, new DateTime(2024, 4, 17, 19, 26, 52, 140, DateTimeKind.Local).AddTicks(9382), "7605", "c6bc76d0-9af8-44ee-a228-55fb932fa1f37" },
                    { 15, 2, true, 1, new DateTime(2024, 4, 17, 19, 26, 52, 140, DateTimeKind.Local).AddTicks(9385), "7506", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f38" },
                    { 16, 2, true, 1, new DateTime(2024, 4, 17, 19, 26, 52, 140, DateTimeKind.Local).AddTicks(9439), "7507", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f39" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "City", "ConcurrencyStamp", "Country", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationId", "SecurityStamp", "Team", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f38", 0, 0, "Dimitrovgrad", "5a2f09ae-b9d7-44c2-94ee-fc4adef1aaac", "Bulgaria", "ApplicationUser", "dimitrichko@gabrovoultra.bg", false, "Dimitrichko", 0, "Dimitrichkov", false, null, "DIMITRICHKO@GABROVOULTRA.BG", "DIMITRICHKO@GABROVOULTRA.BG", "AQAAAAIAAYagAAAAEGFiCmMTb8Pi1Mj0Rqxb72uDHeGai6yFHFfo0r4G2lAfBkJSJ7cob1bu7zwaBRMpsw==", null, false, 15, "a04b229a-d77d-4320-86e7-8f6da2d7b341", null, false, "dimitrichko@gabrovoultra.bg" },
                    { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f39", 0, 0, "Veliko Tarnovo", "416e5190-8141-4284-a372-2628ceb9b0e8", "Bulgaria", "ApplicationUser", "filip@gabrovoultra.bg", false, "Filip", 0, "Filipov", false, null, "FILIP@GABROVOULTRA.BG", "FILIP@GABROVOULTRA.BG", "AQAAAAIAAYagAAAAEP5V22UZwDOeXgm/sr/wC6C1D5k4Ow8V29Yy/1l4EqARKa6vZV4fRAsrca3MX22arw==", null, false, 16, "665c62c5-4b5b-4c57-8c14-c9161ba23678", null, false, "filip@gabrovoultra.bg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80908387-bbd3-404f-a019-90f77d87adf8", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f40");

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0d307f6-d2ac-4ffa-af33-23f35cdd4dd8", "AQAAAAIAAYagAAAAEHxhUXXY/muQo4uqYg8YhklUDdwZAM40k7u7nTWYar6xRfWZr/y/j2OeVwhcmWZ3tw==", "3d013a08-3e3e-4aca-8354-d4b6be823e53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5df07ce0-38dd-45f9-bbff-dcc81f1381c1", "AQAAAAIAAYagAAAAEB5xCjil7I5Au6nGNxwWmcfLaRx+ygbrgNJAjhtsATs8xn7fTbFy8uneT5YS1EJTHw==", "5de0f7f3-54ae-4a1c-a089-807d15fbb475" });

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 4, 33, 919, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 4, 33, 919, DateTimeKind.Local).AddTicks(7402));
        }
    }
}
