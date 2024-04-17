using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrovoUltraWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addadminroletoadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4be6dd46-69ab-4c08-a820-bcb4bb3d2922", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f40" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4be6dd46-69ab-4c08-a820-bcb4bb3d2922", "c6bc76d0-9af8-44ee-a228-55fb9bfa1f40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "040c6515-044d-4773-85f7-6ba637a3b61f", "AQAAAAIAAYagAAAAECi9wxfGrku4b1y5r4WobR+Vz9paMf6xDXFnJfVFmXdgkbb0Ekfi9A3QUx/aX2KPeQ==", "a96f660b-821b-4c0b-9411-6870f6a10282" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7523cb2-b34d-4454-962f-32f4755d8abf", "AQAAAAIAAYagAAAAEFjm3zlIGZRQYXwdRVNfTpwH1ZuvruLDADrUA51velFK5I0tZe7XNuX5F+uQM7LpTw==", "273229c7-29ba-45ed-a81b-4ae261c4e25e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a2f09ae-b9d7-44c2-94ee-fc4adef1aaac", "AQAAAAIAAYagAAAAEGFiCmMTb8Pi1Mj0Rqxb72uDHeGai6yFHFfo0r4G2lAfBkJSJ7cob1bu7zwaBRMpsw==", "a04b229a-d77d-4320-86e7-8f6da2d7b341" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "416e5190-8141-4284-a372-2628ceb9b0e8", "AQAAAAIAAYagAAAAEP5V22UZwDOeXgm/sr/wC6C1D5k4Ow8V29Yy/1l4EqARKa6vZV4fRAsrca3MX22arw==", "665c62c5-4b5b-4c57-8c14-c9161ba23678" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6bc76d0-9af8-44ee-a228-55fb9bfa1f40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e73e925c-8676-42f6-9f6f-b246b2ec42db", "AQAAAAIAAYagAAAAEHomL7Qqz/TFyAm56YGcxUEdXSgPOCLyZRuhUkEnSRHEPYJpufeDVdStN7fhC0cpvQ==", "36c8e73c-36bc-4041-9dd0-f5941b94200f" });

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 12,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 26, 52, 140, DateTimeKind.Local).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 13,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 26, 52, 140, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 14,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 26, 52, 140, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 15,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 26, 52, 140, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 16,
                column: "RegistrationDate",
                value: new DateTime(2024, 4, 17, 19, 26, 52, 140, DateTimeKind.Local).AddTicks(9439));
        }
    }
}
