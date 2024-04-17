using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixuseremail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2a4acb42-d219-43e3-8883-d05868e97d47", "pesho@gabrovoultra.bg", "AQAAAAIAAYagAAAAEAvvSJN2wLfJFuFA+z0SFjexXg8pYPw3lMu9XbWCC60bqpoAwSwCCm50jL9otQwzZQ==", "6aacc378-1576-45c3-bf67-ee456d2e837d", "pesho@gabrovoultra.bg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a0d39d0b-9fb6-450e-b4aa-faa7727e2468", "pesho@gabrovoutra.bg", "AQAAAAIAAYagAAAAEOLq1HIkulIqWm1ZiyQM2xKId8+h87lULDFvSb/Cr+4G33RmC4vHYkMYiLFdCHmesw==", "3f782ad3-7d85-4ac4-a315-f8b026df6761", "pesho@gabrovoutra.bg" });
        }
    }
}
