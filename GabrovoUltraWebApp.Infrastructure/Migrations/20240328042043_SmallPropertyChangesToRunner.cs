using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SmallPropertyChangesToRunner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Runners",
                type: "nvarchar(450)",
                nullable: false,
                comment: "ForeignKey to AspNetUsers table",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Runners",
                type: "int",
                nullable: false,
                comment: "Gender of the runner",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Runners",
                type: "int",
                nullable: false,
                comment: "Age of the runner",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Runners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Email of the runner/user");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Runners");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Runners",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "ForeignKey to AspNetUsers table");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Runners",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Gender of the runner");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Runners",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Age of the runner");
        }
    }
}
