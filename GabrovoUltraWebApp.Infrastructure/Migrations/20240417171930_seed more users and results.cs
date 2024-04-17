using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedmoreusersandresults : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "318cf0dc-6647-4c7a-a03d-bb7256521b0b", "AQAAAAIAAYagAAAAEE0PpCp5+DYqluxxCF/69U5FjC69gaab/UC+4iNetZDRm265dYcKSW12hSTY0CdRig==", "03847e0f-d2e1-4302-b1eb-ab0a909e48d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c689085-d420-40da-8d31-c7f13a2a9a6c", "AQAAAAIAAYagAAAAEHSJmnWeyaYm92vp5/ZLGsmbp6vWYtC0uAgVk/oFykczWvARsTuUBtwbXgHq/7x1tw==", "df755e15-a989-4fab-aa06-e4a137a91488" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89fd66c5-4a34-4eef-b58c-1e6cc94e196c", "AQAAAAIAAYagAAAAENaejHFNfwPSE6ZxKanRNe74Km1DzZhdMbyykGuC3oJUvIAweeYfbprb5fm+fuBQ2g==", "cff8d8b8-aaf3-4ce1-ac98-7142762b44e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57e051f3-601b-4ff1-8f61-199451f81f2e", "AQAAAAIAAYagAAAAEK+6mSX7/JP3IG7PVyUJpA9M7SbwmOq2m2Muynfq6CLA0NmiwTtJkc//95GaJNu4Ww==", "b49067a2-40b0-48d6-8034-db81cdf8abd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3844d1b3-02ff-41d0-a054-f9861b216484", "AQAAAAIAAYagAAAAEAmf0rKNufN+9WRa7/pkQb4mhPq9sfpmCPHd6QhTTL9ZS1SHaayx2ihQM2Er3oCeFA==", "8e10ea2a-4472-4dd4-a094-eb0cfe42dd08" });

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "DistanceId", "IsPaymentConfirmed", "RaceId", "RegistrationDate", "StartingNumber", "UserId" },
                values: new object[,]
                {
                    { 17, 2, true, 1, new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3254), "7508", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f41" },
                    { 18, 4, true, 1, new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3257), "7509", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f42" },
                    { 19, 2, true, 1, new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3259), "7510", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f43" },
                    { 20, 3, true, 1, new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3262), "7511", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f44" },
                    { 21, 4, true, 1, new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3264), "7512", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f45" },
                    { 22, 4, true, 1, new DateTime(2024, 4, 17, 20, 19, 25, 957, DateTimeKind.Local).AddTicks(3267), "7513", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f46" }
                });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "Id", "CategoryRank", "FinishTme", "OverallRank", "RegistrationId" },
                values: new object[,]
                {
                    { 11, 0, new TimeSpan(0, 3, 30, 0, 0), 0, 12 },
                    { 12, 0, new TimeSpan(0, 3, 45, 0, 0), 0, 13 },
                    { 13, 0, new TimeSpan(0, 3, 50, 0, 0), 0, 14 },
                    { 14, 0, new TimeSpan(0, 3, 55, 0, 0), 0, 15 },
                    { 15, 0, new TimeSpan(0, 4, 0, 0, 0), 0, 16 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "City", "ConcurrencyStamp", "Country", "Discriminator", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationId", "SecurityStamp", "Team", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f41", 0, 0, "Ivanovgrad", "33e0f7aa-3157-45be-9f2e-53c4dc86e013", "Bulgaria", "ApplicationUser", "ivan@gabrovoultra.bg", false, "Ivan", 0, "Ivanov", false, null, "IVAN@GABROVOULTRA.BG", "IVAN@GABROVOULTRA.BG", "AQAAAAIAAYagAAAAEP8wojNg3cLBzIDsjFix8qCQw9Vew9qu8oc5MuNV9OEE9dwOo1XGXvxl1C/xw/AKPg==", null, false, 17, "2b603e69-1ba1-45fe-bad3-9e30ac70d4fa", null, false, "ivan@gabrovoultra.bg" },
                    { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f42", 0, 0, "Stefanovgrad", "1428cb70-9bf5-4fe4-a872-7c89447582ce", "Bulgaria", "ApplicationUser", "stefan@gabrovoultra.bg", false, "Stefan", 0, "Stefanov", false, null, "STEFAN@GABROVOULTRA.BG", "STEFAN@GABROVOULTRA.BG", "AQAAAAIAAYagAAAAENej2TPCrfkEz8b9gylNfock49p89mtcwT2H70xbNqy89AleBE076XTnlrPWgpbhyQ==", null, false, 18, "1a7d4546-1c32-47ae-ba40-60935fecf4b1", null, false, "stefan@gabrovoultra.bg" },
                    { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f43", 0, 0, "Miroslavovgrad", "dd0c361a-74c5-4681-9824-9d4acc07f583", "Bulgaria", "ApplicationUser", "miroslav@gabrovoultra.bg", false, "Miroslav", 0, "Miroslavov", false, null, "MIROSLAV@GABROVOULTRA.BG", "MIROSLAV@GABROVOULTRA.BG", "AQAAAAIAAYagAAAAEOInUiAcTusfADatAmTxtVd3/HHsyRKUIao4tr95at0HUQ8Q/waOEpa3w8s7OHPspA==", null, false, 19, "59996d96-0e21-4b1c-858d-f33c110939d7", null, false, "miroslav@gabrovoultra.bg" },
                    { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f44", 0, 0, "Svetoslavovgrad", "aa35f414-badc-4a49-8f83-e3e0525cd91d", "Bulgaria", "ApplicationUser", "svetoslav@gabrovoultra.bg", false, "Svetoslav", 0, "Svetoslavov", false, null, "SVETOSLAV@GABROVOULTRA.BG", "SVETOSLAV@GABROVOULTRA.BG", "AQAAAAIAAYagAAAAED5BmFAGSZS0SYzhPQoYYhrVHuke0me9WPhvBZ3gmlQLdYcNh2GGZ+vRgD6LUhKJBQ==", null, false, 20, "96d11234-580e-4f0f-837a-4c34f57ed3f4", null, false, "svetoslav@gabrovoultra.bg" },
                    { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f45", 0, 0, "Gabrovo", "583d4642-a1cd-4bee-9f48-946d72680963", "Bulgaria", "ApplicationUser", "mihael@gabrovoultra.bg", false, "Mihael", 0, "Yordanov", false, null, "MIHAEL@GABROVOULTRA.BG", "MIHAEL@GABROVOULTRA.BG", "AQAAAAIAAYagAAAAEJYEg1bVuJibtQiwB4RlZIOhaf8tYvj1g8HN+mVOwL167iRrS9BnAVP62BUCc5fFwA==", null, false, 21, "fae43a01-2ca1-4e37-9826-a03110ef7606", null, false, "mihael@gabrovoultra.bg" },
                    { "c6bc76d0-9af8-44ee-a228-55fb9bfa1f46", 0, 0, "Gabrovo", "b18a313f-bc4e-4670-8f0d-190e2782795a", "Bulgaria", "ApplicationUser", "svetoslava@gabrovoultra.bg", false, "Svetoslava", 0, "Tsankova", false, null, "SVETOSLAVA@GABROVOULTRA.BG", "SVETOSLAVA@GABROVOULTRA.BG", "AQAAAAIAAYagAAAAED1K5LkoXomjfn2pf8tX0M5dbDVegyvZwW2CcvrJa8xir03F0A2RIQ0bNoXWpeBong==", null, false, 22, "7262f669-2029-47b9-a454-92f12ed98a94", null, false, "svetoslava@gabrovoultra.bg" }
                });

            migrationBuilder.InsertData(
                table: "Results",
                columns: new[] { "Id", "CategoryRank", "FinishTme", "OverallRank", "RegistrationId" },
                values: new object[,]
                {
                    { 16, 0, new TimeSpan(0, 4, 5, 0, 0), 0, 17 },
                    { 17, 0, new TimeSpan(0, 4, 10, 0, 0), 0, 18 },
                    { 18, 0, new TimeSpan(0, 4, 15, 0, 0), 0, 19 },
                    { 19, 0, new TimeSpan(0, 4, 20, 0, 0), 0, 20 },
                    { 20, 0, new TimeSpan(0, 4, 25, 0, 0), 0, 21 },
                    { 21, 0, new TimeSpan(0, 4, 30, 0, 0), 0, 22 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f46");

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Results",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7fa2c27-cfc2-44ab-b5e2-b8860534365f", "AQAAAAIAAYagAAAAEHnV54wui5SgnAS0hRp71Dkja1f4yTvzdIQwnQYRthFvq5cdG3UD8lQl6tj5+r3E0Q==", "6d882ee4-a7f2-4097-a0b6-b3dffa30c37b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaedbc7e-3ed7-42ec-a3ec-0e6d068e258d", "AQAAAAIAAYagAAAAEEL0QUxs+9jTkgKxke5+/Oyddquh6NBKSGxFsm6ft/OSDMEJ+YahHNpYY4ORn1Mo0A==", "82d4c92f-cc54-4b11-9129-80bf15fda4a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2875ce8-43ae-46b8-b83f-e86564fbb493", "AQAAAAIAAYagAAAAEGWp4GcTE1GRAPnPwFoc2ecuH/Qm/HeAxA42X7/1+8/fIebxvVag/8rvraaHgjhFaw==", "3dd65301-c395-4b1d-a48e-020efc9cd2d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17165e36-e92f-4fb9-9029-594dc251ae60", "AQAAAAIAAYagAAAAECUF8kzAmbwce0Id7y3uk+5CdVTSa33VxGAmFMU3SSo5cy+SM5A3mUA82UFEuAYQZQ==", "d7c9a578-5752-4898-be78-d7543ca06566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efd68b40-fbd7-4288-88f3-01924de51017", "AQAAAAIAAYagAAAAELRsRug5bXKuqI1CLBa7lwEdGkjJL2k3sxUkUzW/LFLIpYtG9uxQnKpr7zocG9GdNg==", "9a34c910-d93c-43e1-a8ab-9bf0300dd54f" });

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 28, 49, 117, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 28, 49, 117, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 28, 49, 117, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 28, 49, 117, DateTimeKind.Local).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 28, 49, 117, DateTimeKind.Local).AddTicks(3954));
        }
    }
}
