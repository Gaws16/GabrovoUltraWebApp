using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Adjustproperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartingNumber",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "StartingNumber",
                table: "Registrations",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Distances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartingNumber",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Distances");

            migrationBuilder.AddColumn<string>(
                name: "StartingNumber",
                table: "AspNetUsers",
                type: "nvarchar(6)",
                maxLength: 6,
                nullable: true,
                comment: "Starting number of the runner");
        }
    }
}
