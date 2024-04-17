using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedRegistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d9df7f4-fb7f-40ed-9869-7f7dd0ca1906", "AQAAAAIAAYagAAAAEPIPNLArlPH+6J0z728s8Q+0TDMw4oO9Cq5kZBq8C0HRa1NiTdHQhQYZCXEQwjEsnw==", "12e55441-24ca-41df-bed2-c6d8c7e79e16" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DistanceId", "IsPaymentConfirmed", "RaceId", "RegistrationDate", "StartingNumber", "UserId" },
                values: new object[] { 11, 2, true, 1, new DateTime(2024, 4, 17, 18, 46, 59, 241, DateTimeKind.Local).AddTicks(4869), "7504", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a4acb42-d219-43e3-8883-d05868e97d47", "AQAAAAIAAYagAAAAEAvvSJN2wLfJFuFA+z0SFjexXg8pYPw3lMu9XbWCC60bqpoAwSwCCm50jL9otQwzZQ==", "6aacc378-1576-45c3-bf67-ee456d2e837d" });
        }
    }
}
