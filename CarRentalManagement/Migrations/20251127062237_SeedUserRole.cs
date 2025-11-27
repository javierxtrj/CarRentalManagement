using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(3935), new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(3959), new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4587), new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4780), new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4383), new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4387), new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4390), new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4394), new DateTime(2025, 11, 27, 14, 22, 35, 914, DateTimeKind.Local).AddTicks(4395) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2438), new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2459), new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(3014), new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(3015) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(3018), new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2823), new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2827), new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2831), new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2834), new DateTime(2025, 11, 27, 13, 28, 48, 449, DateTimeKind.Local).AddTicks(2835) });
        }
    }
}
