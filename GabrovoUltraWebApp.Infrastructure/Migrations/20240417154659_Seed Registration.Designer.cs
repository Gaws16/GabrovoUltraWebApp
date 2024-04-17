﻿// <auto-generated />
using System;
using GabrovoUltraWebApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    [DbContext(typeof(GabrovoUltraContext))]
    [Migration("20240417154659_Seed Registration")]
    partial class SeedRegistration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaxAge")
                        .HasColumnType("int");

                    b.Property<int>("MinAge")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MaxAge = 21,
                            MinAge = 16,
                            Name = "Юнуша",
                            RaceId = 1
                        },
                        new
                        {
                            Id = 2,
                            MaxAge = 35,
                            MinAge = 22,
                            Name = "Младши",
                            RaceId = 1
                        },
                        new
                        {
                            Id = 3,
                            MaxAge = 49,
                            MinAge = 36,
                            Name = "Старши",
                            RaceId = 1
                        },
                        new
                        {
                            Id = 4,
                            MaxAge = 100,
                            MinAge = 50,
                            Name = "Ветеран",
                            RaceId = 1
                        },
                        new
                        {
                            Id = 5,
                            MaxAge = 21,
                            MinAge = 16,
                            Name = "Юнуша",
                            RaceId = 2
                        },
                        new
                        {
                            Id = 6,
                            MaxAge = 35,
                            MinAge = 22,
                            Name = "Младши",
                            RaceId = 2
                        },
                        new
                        {
                            Id = 7,
                            MaxAge = 49,
                            MinAge = 36,
                            Name = "Старши",
                            RaceId = 2
                        },
                        new
                        {
                            Id = 8,
                            MaxAge = 100,
                            MinAge = 50,
                            Name = "Ветеран",
                            RaceId = 2
                        });
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Distance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("PrimaryKey");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasComment("Description of the distance");

                    b.Property<double>("ElevationGain")
                        .HasColumnType("float")
                        .HasComment("Elevation gain of the distance in meters");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Length")
                        .HasColumnType("float")
                        .HasComment("Length of the distance in kilometers");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Name of the distance");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<string>("StartTime")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)")
                        .HasComment("Start time of the distance");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("Distances");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "75км с 4300 D+ и пълна автономност - без никакви подрекрепителни пунктве. Истинско изпитание.",
                            ElevationGain = 4300.0,
                            ImagePath = "/Components/Distances/trqnva1.jpg",
                            Length = 75.0,
                            Name = "Черешката",
                            RaceId = 1,
                            StartTime = "06:09"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Маратонски 42км с над 2500 D+ и пълна автономност - без никакви подрекрепителни пунктве. По-малкото \"мъчение\".",
                            ElevationGain = 2500.0,
                            ImagePath = "/Components/Distances/kodja-kaq.jpg",
                            Length = 42.0,
                            Name = "Глазурата",
                            RaceId = 1,
                            StartTime = "08:00"
                        },
                        new
                        {
                            Id = 3,
                            Description = "30км Sky с 1950 D+ и пълна автономност - без никакви подрекрепителни пунктве. Предизвикателството.",
                            ElevationGain = 1950.0,
                            ImagePath = "/Components/Distances/tarnovo.jpg",
                            Length = 30.0,
                            Name = "Блатът",
                            RaceId = 1,
                            StartTime = "09:30"
                        },
                        new
                        {
                            Id = 4,
                            Description = "14км с 1050 D+ и пълна автономност - без никакви подрекрепителни пунктве. Напреднало ниво.",
                            ElevationGain = 1050.0,
                            ImagePath = "/Components/Distances/trqnva1.jpg",
                            Length = 14.0,
                            Name = "Жилката",
                            RaceId = 1,
                            StartTime = "12:00"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Скоростно изкачване на Телевизионната кула (Градище) 3.6км с 500 D+. Допълнително изпитание, в което всеки може да се включи.",
                            ElevationGain = 50.0,
                            ImagePath = "/Components/Distances/trqnva1.jpg",
                            Length = 5.0,
                            Name = "Допълнителен десерт",
                            RaceId = 1,
                            StartTime = "14:00"
                        });
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.HeroSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("HeroSections");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "nqkakav si tam lorem ipsum",
                            ImageUrl = "/public/VititeSkaliView.jpg",
                            Name = "Vitite skali view"
                        },
                        new
                        {
                            Id = 2,
                            Description = "gotina magla koqto ne se vijda na snimkata",
                            ImageUrl = "/public/Integra2.jpg",
                            Name = "Integral view 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Super qkiq deskription!",
                            ImageUrl = "/public/Integral.jpg",
                            Name = "Integral"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Super qkiq motivacionen citat",
                            ImageUrl = "/public/Skali.jpg",
                            Name = "Samo skali"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Malko kofti snimka",
                            ImageUrl = "/public/GradishteSunSet.jpg",
                            Name = "Gradishte"
                        },
                        new
                        {
                            Id = 6,
                            Description = "snimano na greshnata strana",
                            ImageUrl = "/public/IspolinSunset.jpg",
                            Name = "Ispolin"
                        });
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("PrimaryKey");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasComment("Description of the race");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasComment("Location of the race");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Name of the race");

                    b.HasKey("Id");

                    b.ToTable("Races");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Второ издание на невероятното трейл приключение",
                            Location = "Габрово",
                            Name = "Габрово Ултра 2024"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Първото първо по рода си трейл състезание в Габрово",
                            Location = "Габрово",
                            Name = "Габрово Ултра 2023"
                        });
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Registration Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DistanceId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPaymentConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartingNumber")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Foreign key to ASPUsers");

                    b.HasKey("Id");

                    b.HasIndex("DistanceId");

                    b.HasIndex("RaceId");

                    b.ToTable("Registrations");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            DistanceId = 2,
                            IsPaymentConfirmed = true,
                            RaceId = 1,
                            RegistrationDate = new DateTime(2024, 4, 17, 18, 46, 59, 241, DateTimeKind.Local).AddTicks(4869),
                            StartingNumber = "7504",
                            UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36"
                        });
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryRank")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("FinishTme")
                        .HasColumnType("time");

                    b.Property<int>("OverallRank")
                        .HasColumnType("int");

                    b.Property<int>("RegistrationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationId")
                        .IsUnique();

                    b.ToTable("Results");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "80908387-bbd3-404f-a019-90f77d87adf8",
                            ConcurrencyStamp = "80908387-bbd3-404f-a019-90f77d87adf8",
                            Name = "Reader",
                            NormalizedName = "READER"
                        },
                        new
                        {
                            Id = "4be6dd46-69ab-4c08-a820-bcb4bb3d2922",
                            ConcurrencyStamp = "4be6dd46-69ab-4c08-a820-bcb4bb3d2922",
                            Name = "Writer",
                            NormalizedName = "WRITER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                            RoleId = "80908387-bbd3-404f-a019-90f77d87adf8"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasComment("Age of the runner");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("City of origin");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Country of origin");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("FirstName of the runner");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasComment("Gender of the runner");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("LastName of the runner");

                    b.Property<int?>("RegistrationId")
                        .HasColumnType("int");

                    b.Property<string>("Team")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Name of the team");

                    b.HasIndex("RegistrationId")
                        .IsUnique()
                        .HasFilter("[RegistrationId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5d9df7f4-fb7f-40ed-9869-7f7dd0ca1906",
                            Email = "pesho@gabrovoultra.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "PESHO@GABROVOULTRA.BG",
                            NormalizedUserName = "PESHO@GABROVOULTRA.BG",
                            PasswordHash = "AQAAAAIAAYagAAAAEPIPNLArlPH+6J0z728s8Q+0TDMw4oO9Cq5kZBq8C0HRa1NiTdHQhQYZCXEQwjEsnw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "12e55441-24ca-41df-bed2-c6d8c7e79e16",
                            TwoFactorEnabled = false,
                            UserName = "pesho@gabrovoultra.bg",
                            Age = 0,
                            City = "Gabrovo",
                            Country = "Bulgaria",
                            FirstName = "Pesho",
                            Gender = 0,
                            LastName = "Peshov"
                        });
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Category", b =>
                {
                    b.HasOne("GabrovoUltraWebApp.Infrastructure.Data.Models.Race", "Race")
                        .WithMany("Categories")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Race");
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Distance", b =>
                {
                    b.HasOne("GabrovoUltraWebApp.Infrastructure.Data.Models.Race", "Race")
                        .WithMany("Distances")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Race");
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Registration", b =>
                {
                    b.HasOne("GabrovoUltraWebApp.Infrastructure.Data.Models.Distance", "Distance")
                        .WithMany("Registrations")
                        .HasForeignKey("DistanceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GabrovoUltraWebApp.Infrastructure.Data.Models.Race", "Race")
                        .WithMany("Registrations")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distance");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Result", b =>
                {
                    b.HasOne("GabrovoUltraWebApp.Infrastructure.Data.Models.Registration", "Registration")
                        .WithOne("Result")
                        .HasForeignKey("GabrovoUltraWebApp.Infrastructure.Data.Models.Result", "RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("GabrovoUltraWebApp.Infrastructure.Data.Models.Registration", "Registration")
                        .WithOne("User")
                        .HasForeignKey("GabrovoUltraWebApp.Infrastructure.Data.Models.ApplicationUser", "RegistrationId");

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Distance", b =>
                {
                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Race", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Distances");

                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("GabrovoUltraWebApp.Infrastructure.Data.Models.Registration", b =>
                {
                    b.Navigation("Result")
                        .IsRequired();

                    b.Navigation("User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
