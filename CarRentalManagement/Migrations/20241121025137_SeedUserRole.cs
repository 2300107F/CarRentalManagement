using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f44d6c39-b078-4251-9fc0-9860d9fc7cb3", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHxm04Ya3qKNbmrzt08o8D87DoLkEFuSAXkkvt1fwmEgNZlhRakhZHqmptm4x0oo6w==", null, false, "53306bda-b83c-4282-9a76-c9f8325c257c", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9156), new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9176), new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9704), new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9709), new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9914), new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9915) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9917), new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 11, 21, 10, 51, 36, 170, DateTimeKind.Local).AddTicks(9921) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(5592), new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(5612), new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(5942), new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(5946), new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(6089), new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(6093), new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(6095), new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(6098), new DateTime(2024, 11, 20, 11, 35, 35, 745, DateTimeKind.Local).AddTicks(6098) });
        }
    }
}
