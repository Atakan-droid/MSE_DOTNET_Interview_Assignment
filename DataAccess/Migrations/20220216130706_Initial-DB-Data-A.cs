using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialDBDataA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Heat",
                table: "Stations");

            migrationBuilder.UpdateData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 840, DateTimeKind.Local).AddTicks(5086), new DateTime(2022, 2, 16, 16, 7, 5, 840, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 840, DateTimeKind.Local).AddTicks(5484), new DateTime(2022, 2, 16, 16, 7, 5, 840, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 840, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 2, 16, 16, 7, 5, 840, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 840, DateTimeKind.Local).AddTicks(5493), new DateTime(2022, 2, 16, 16, 7, 5, 840, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 830, DateTimeKind.Local).AddTicks(260), new DateTime(2022, 2, 16, 16, 7, 5, 831, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 831, DateTimeKind.Local).AddTicks(2516), new DateTime(2022, 2, 16, 16, 7, 5, 831, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 831, DateTimeKind.Local).AddTicks(2526), new DateTime(2022, 2, 16, 16, 7, 5, 831, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 839, DateTimeKind.Local).AddTicks(3426), new DateTime(2022, 2, 16, 16, 7, 5, 839, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 839, DateTimeKind.Local).AddTicks(5539), new DateTime(2022, 2, 16, 16, 7, 5, 839, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 839, DateTimeKind.Local).AddTicks(5549), new DateTime(2022, 2, 16, 16, 7, 5, 839, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 841, DateTimeKind.Local).AddTicks(6150), new DateTime(2022, 2, 16, 16, 7, 5, 841, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 841, DateTimeKind.Local).AddTicks(7802), new DateTime(2022, 2, 16, 16, 7, 5, 841, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 16, 7, 5, 841, DateTimeKind.Local).AddTicks(7811), new DateTime(2022, 2, 16, 16, 7, 5, 841, DateTimeKind.Local).AddTicks(7812) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Heat",
                table: "Stations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(628), new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1005), new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1011), new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1013), new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 419, DateTimeKind.Local).AddTicks(3675), new DateTime(2022, 2, 16, 14, 59, 41, 420, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 420, DateTimeKind.Local).AddTicks(8190), new DateTime(2022, 2, 16, 14, 59, 41, 420, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 420, DateTimeKind.Local).AddTicks(8198), new DateTime(2022, 2, 16, 14, 59, 41, 420, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Heat", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 428, DateTimeKind.Local).AddTicks(9205), 70m, new DateTime(2022, 2, 16, 14, 59, 41, 428, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Heat", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 429, DateTimeKind.Local).AddTicks(1294), 50m, new DateTime(2022, 2, 16, 14, 59, 41, 429, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Heat", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 429, DateTimeKind.Local).AddTicks(1305), 75m, new DateTime(2022, 2, 16, 14, 59, 41, 429, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(1117), new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(2522), new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(2529), new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(2530) });
        }
    }
}
