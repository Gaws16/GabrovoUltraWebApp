using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationwithfixedrealtionships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HeroSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "PrimaryKey")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of the race"),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "Description of the race"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Location of the race")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MinAge = table.Column<int>(type: "int", nullable: false),
                    MaxAge = table.Column<int>(type: "int", nullable: false),
                    RaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "PrimaryKey")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Name of the distance"),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, comment: "Description of the distance"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, comment: "Start time of the distance"),
                    Length = table.Column<double>(type: "float", nullable: false, comment: "Length of the distance in kilometers"),
                    ElevationGain = table.Column<double>(type: "float", nullable: false, comment: "Elevation gain of the distance in meters"),
                    RaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Distances_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Registration Id")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Foreign key to ASPUsers"),
                    RaceId = table.Column<int>(type: "int", nullable: false),
                    DistanceId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaymentConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    StartingNumber = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registrations_Distances_DistanceId",
                        column: x => x.DistanceId,
                        principalTable: "Distances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Registrations_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "FirstName of the runner"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "LastName of the runner"),
                    Age = table.Column<int>(type: "int", nullable: true, comment: "Age of the runner"),
                    Gender = table.Column<int>(type: "int", nullable: true, comment: "Gender of the runner"),
                    Team = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, comment: "Name of the team"),
                    RegistrationId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Registrations_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registrations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    FinishTme = table.Column<TimeSpan>(type: "time", nullable: true),
                    OverallRank = table.Column<int>(type: "int", nullable: false),
                    CategoryRank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Registrations_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4be6dd46-69ab-4c08-a820-bcb4bb3d2922", "4be6dd46-69ab-4c08-a820-bcb4bb3d2922", "Writer", "WRITER" },
                    { "80908387-bbd3-404f-a019-90f77d87adf8", "80908387-bbd3-404f-a019-90f77d87adf8", "Reader", "READER" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RegistrationId",
                table: "AspNetUsers",
                column: "RegistrationId",
                unique: true,
                filter: "[RegistrationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_RaceId",
                table: "Categories",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Distances_RaceId",
                table: "Distances",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_DistanceId",
                table: "Registrations",
                column: "DistanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_RaceId",
                table: "Registrations",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_RegistrationId",
                table: "Results",
                column: "RegistrationId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "HeroSections");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Distances");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
