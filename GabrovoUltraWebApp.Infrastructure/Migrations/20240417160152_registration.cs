using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class registration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationId", "SecurityStamp" },
                values: new object[] { "a6c76b41-c301-4a6f-9776-9365973e34a4", "AQAAAAIAAYagAAAAED3k8Jy18feDMMVsD5LB7WH+g8W8DeOrNMB/AN15wBErN+riBOZKF/ZWMXS1Awhokg==", 12, "29d51084-fad7-421a-92e0-f3b4fcebe34b" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DistanceId", "IsPaymentConfirmed", "RaceId", "RegistrationDate", "StartingNumber", "UserId" },
                values: new object[] { 12, 2, true, 1, new DateTime(2024, 4, 17, 19, 1, 52, 169, DateTimeKind.Local).AddTicks(3358), "7505", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegistrationId", "SecurityStamp" },
                values: new object[] { "5d9df7f4-fb7f-40ed-9869-7f7dd0ca1906", "AQAAAAIAAYagAAAAEPIPNLArlPH+6J0z728s8Q+0TDMw4oO9Cq5kZBq8C0HRa1NiTdHQhQYZCXEQwjEsnw==", null, "12e55441-24ca-41df-bed2-c6d8c7e79e16" });

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DistanceId", "IsPaymentConfirmed", "RaceId", "RegistrationDate", "StartingNumber", "UserId" },
                values: new object[] { 11, 2, true, 1, new DateTime(2024, 4, 17, 18, 46, 59, 241, DateTimeKind.Local).AddTicks(4869), "7504", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36" });
        }
    }
}
