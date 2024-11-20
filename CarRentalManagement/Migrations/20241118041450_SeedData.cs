using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(1953), new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(1966), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(1969), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2161), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2163), new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2163), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2267), new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2267), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2269), new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2270), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2271), new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2272), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2272), new DateTime(2024, 11, 18, 12, 14, 49, 496, DateTimeKind.Local).AddTicks(2273), "C-HR", "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ColourId",
                table: "Vehicle",
                column: "ColourId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_MakeId",
                table: "Vehicle",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ModelId",
                table: "Vehicle",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_VehicleId",
                table: "Booking",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Vehicle_VehicleId",
                table: "Booking",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Colour_ColourId",
                table: "Vehicle",
                column: "ColourId",
                principalTable: "Colour",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Make_MakeId",
                table: "Vehicle",
                column: "MakeId",
                principalTable: "Make",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Model_ModelId",
                table: "Vehicle",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Vehicle_VehicleId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Colour_ColourId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Make_MakeId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Model_ModelId",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_ColourId",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_MakeId",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_ModelId",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_VehicleId",
                table: "Booking");

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Booking");
        }
    }
}
