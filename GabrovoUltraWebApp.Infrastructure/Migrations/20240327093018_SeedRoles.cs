using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Runners");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Runners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Runners",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "FirstName of the runner");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Runners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Runners",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "LastName of the runner");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4be6dd46-69ab-4c08-a820-bcb4bb3d2922", "4be6dd46-69ab-4c08-a820-bcb4bb3d2922", "Writer", "WRITER" },
                    { "80908387-bbd3-404f-a019-90f77d87adf8", "80908387-bbd3-404f-a019-90f77d87adf8", "Reader", "READER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4be6dd46-69ab-4c08-a820-bcb4bb3d2922");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80908387-bbd3-404f-a019-90f77d87adf8");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Runners");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Runners");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Runners");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Runners");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Runners",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Name of the runner");
        }
    }
}
