using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixlocout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0d39d0b-9fb6-450e-b4aa-faa7727e2468", "AQAAAAIAAYagAAAAEOLq1HIkulIqWm1ZiyQM2xKId8+h87lULDFvSb/Cr+4G33RmC4vHYkMYiLFdCHmesw==", "3f782ad3-7d85-4ac4-a315-f8b026df6761" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8190e04a-e92e-4ebf-9e77-30275d37901c", "AQAAAAIAAYagAAAAECsL/mDfP48oEtxGVEFEixMisbFgRoZRQCEkINXCkMTrWGDjpgb76kBtdwUnfpd+TQ==", "80492657-e2ca-404f-bed9-4c369c791c82" });
        }
    }
}
