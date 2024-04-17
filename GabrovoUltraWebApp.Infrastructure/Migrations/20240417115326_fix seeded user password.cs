using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixseededuserpassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8190e04a-e92e-4ebf-9e77-30275d37901c", "AQAAAAIAAYagAAAAECsL/mDfP48oEtxGVEFEixMisbFgRoZRQCEkINXCkMTrWGDjpgb76kBtdwUnfpd+TQ==", "80492657-e2ca-404f-bed9-4c369c791c82" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c791442b-1665-43cd-aac8-9273386d45ef", "AQAAAAIAAYagAAAAEN8DN3pdjqCmXKo2X11nMPojEWxcm7W5o8OJAZfQRGbHU9DTLKcO5c1Cs3n4jnfO0w==", "f5784dfa-a588-4e79-b3af-f50602ad9dbe" });
        }
    }
}
