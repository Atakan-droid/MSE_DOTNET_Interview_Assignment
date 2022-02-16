using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialDBData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Temperature",
                table: "Stations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "ProductionLines",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "LineName", "ModifiedDate", "isActive" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(628), false, "A Üretim Yolu", new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(635), false },
                    { 2, new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1005), false, "B Üretim Yolu", new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1009), false },
                    { 3, new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1011), false, "C Üretim Yolu", new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1012), false },
                    { 4, new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1013), false, "D Üretim Yolu", new DateTime(2022, 2, 16, 14, 59, 41, 430, DateTimeKind.Local).AddTicks(1014), false }
                });

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(1117), new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Mail", "ModifiedDate", "Name", "Password", "RoleID", "Surname", "isActive" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(2522), false, "atakangocer98@gmail.com", new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(2526), "Atakan", "123456", 2, "Göçer", false },
                    { 3, new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(2529), false, "mock@gmail.com", new DateTime(2022, 2, 16, 14, 59, 41, 431, DateTimeKind.Local).AddTicks(2530), "User", "123456", 3, "UserSurname", false }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "CreatedDate", "Heat", "IsDeleted", "LineId", "MaintenanceStaffId", "ModifiedDate", "Pressure", "StationName", "Status", "Temperature", "isActive" },
                values: new object[] { 1, new DateTime(2022, 2, 16, 14, 59, 41, 428, DateTimeKind.Local).AddTicks(9205), 70m, false, 1, 2, new DateTime(2022, 2, 16, 14, 59, 41, 428, DateTimeKind.Local).AddTicks(9224), 108m, "Birinci istasyon", "Çalışıyor", 50m, false });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "CreatedDate", "Heat", "IsDeleted", "LineId", "MaintenanceStaffId", "ModifiedDate", "Pressure", "StationName", "Status", "Temperature", "isActive" },
                values: new object[] { 3, new DateTime(2022, 2, 16, 14, 59, 41, 429, DateTimeKind.Local).AddTicks(1305), 75m, false, 2, 2, new DateTime(2022, 2, 16, 14, 59, 41, 429, DateTimeKind.Local).AddTicks(1306), 158m, "Ücüncü istasyon", "Çalışıyor", 2000m, false });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "CreatedDate", "Heat", "IsDeleted", "LineId", "MaintenanceStaffId", "ModifiedDate", "Pressure", "StationName", "Status", "Temperature", "isActive" },
                values: new object[] { 2, new DateTime(2022, 2, 16, 14, 59, 41, 429, DateTimeKind.Local).AddTicks(1294), 50m, false, 3, 3, new DateTime(2022, 2, 16, 14, 59, 41, 429, DateTimeKind.Local).AddTicks(1300), 8m, "Ikinci istasyon", "Çalışıyor", 1m, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductionLines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "Stations");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 13, 14, 36, 32, 126, DateTimeKind.Local).AddTicks(8267), new DateTime(2022, 2, 13, 14, 36, 32, 127, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 13, 14, 36, 32, 127, DateTimeKind.Local).AddTicks(9979), new DateTime(2022, 2, 13, 14, 36, 32, 127, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 13, 14, 36, 32, 127, DateTimeKind.Local).AddTicks(9989), new DateTime(2022, 2, 13, 14, 36, 32, 127, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2022, 2, 13, 14, 36, 32, 138, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 2, 13, 14, 36, 32, 138, DateTimeKind.Local).AddTicks(8331) });
        }
    }
}
