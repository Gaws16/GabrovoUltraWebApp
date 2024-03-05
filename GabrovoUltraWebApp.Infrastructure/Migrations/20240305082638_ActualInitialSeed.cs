using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ActualInitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HeroSections",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "nqkakav si tam lorem ipsum", "/public/VititeSkaliView.jpg", "Vitite skali view" },
                    { 2, "gotina magla koqto ne se vijda na snimkata", "/public/Integra2.jpg", "Integral view 2" },
                    { 3, "Super qkiq deskription!", "/public/Integral.jpg", "Integral" },
                    { 4, "Super qkiq motivacionen citat", "/public/Skali.jpg", "Samo skali" },
                    { 5, "Malko kofti snimka", "/public/GradishteSunSet.jpg", "Gradishte" },
                    { 6, "snimano na greshnata strana", "/public/IspolinSunset.jpg", "Ispolin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HeroSections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HeroSections",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HeroSections",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HeroSections",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HeroSections",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HeroSections",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
