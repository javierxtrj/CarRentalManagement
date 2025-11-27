using System;
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
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6568), new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6587), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6590), new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6592), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(7174), new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(7176), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(7178), new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(7179), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6966), new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6967), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6971), new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6972), "x5", "System" },
                    { 3, "System", new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6975), new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6975), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6978), new DateTime(2025, 11, 27, 11, 59, 14, 378, DateTimeKind.Local).AddTicks(6979), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
