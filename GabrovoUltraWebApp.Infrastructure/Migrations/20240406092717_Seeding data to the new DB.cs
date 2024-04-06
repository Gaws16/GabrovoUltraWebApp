using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedingdatatothenewDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Date", "Description", "Location", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Второ издание на невероятното трейл приключение", "Габрово", "Габрово Ултра 2024" },
                    { 2, new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Първото първо по рода си трейл състезание в Габрово", "Габрово", "Габрово Ултра 2023" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "MaxAge", "MinAge", "Name", "RaceId" },
                values: new object[,]
                {
                    { 1, 21, 16, "Юнуша", 1 },
                    { 2, 35, 22, "Младши", 1 },
                    { 3, 49, 36, "Старши", 1 },
                    { 4, 100, 50, "Ветеран", 1 },
                    { 5, 21, 16, "Юнуша", 2 },
                    { 6, 35, 22, "Младши", 2 },
                    { 7, 49, 36, "Старши", 2 },
                    { 8, 100, 50, "Ветеран", 2 }
                });

            migrationBuilder.InsertData(
                table: "Distances",
                columns: new[] { "Id", "Description", "ElevationGain", "ImagePath", "Length", "Name", "RaceId", "StartTime" },
                values: new object[,]
                {
                    { 1, "75км с 4300 D+ и пълна автономност - без никакви подрекрепителни пунктве. Истинско изпитание.", 4300.0, "/Components/Distances/trqnva1.jpg", 75.0, "Черешката", 1, "06:09" },
                    { 2, "Маратонски 42км с над 2500 D+ и пълна автономност - без никакви подрекрепителни пунктве. По-малкото \"мъчение\".", 2500.0, "/Components/Distances/kodja-kaq.jpg", 42.0, "Глазурата", 1, "08:00" },
                    { 3, "30км Sky с 1950 D+ и пълна автономност - без никакви подрекрепителни пунктве. Предизвикателството.", 1950.0, "/Components/Distances/tarnovo.jpg", 30.0, "Блатът", 1, "09:30" },
                    { 4, "14км с 1050 D+ и пълна автономност - без никакви подрекрепителни пунктве. Напреднало ниво.", 1050.0, "/Components/Distances/trqnva1.jpg", 14.0, "Жилката", 1, "12:00" },
                    { 5, "Скоростно изкачване на Телевизионната кула (Градище) 3.6км с 500 D+. Допълнително изпитание, в което всеки може да се включи.", 50.0, "/Components/Distances/trqnva1.jpg", 5.0, "Допълнителен десерт", 1, "14:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Distances",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
