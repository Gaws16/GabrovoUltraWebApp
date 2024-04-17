using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "80908387-bbd3-404f-a019-90f77d87adf8", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c791442b-1665-43cd-aac8-9273386d45ef", "AQAAAAIAAYagAAAAEN8DN3pdjqCmXKo2X11nMPojEWxcm7W5o8OJAZfQRGbHU9DTLKcO5c1Cs3n4jnfO0w==", "f5784dfa-a588-4e79-b3af-f50602ad9dbe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80908387-bbd3-404f-a019-90f77d87adf8", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a496c9b-92dc-4331-84f5-abce095c2a25", "AQAAAAIAAYagAAAAEL/P2ByDhKeyVxMlAsIPq15kUhdolHlYfaIt45Vh8ZSxM406tph1Z1nv/wudMBrM3Q==", "53881894-11c7-4c4c-9817-d5db5a6d1968" });
        }
    }
}
