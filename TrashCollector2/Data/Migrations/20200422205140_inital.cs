using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector2.Data.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a90c689-2fde-4e28-97bb-381ac3b8635f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60fa405d-3de7-4e6b-8fe5-a675f65a9072", "50ec6342-b7e6-4cec-ab70-b327e65a6d79", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60fa405d-3de7-4e6b-8fe5-a675f65a9072");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2a90c689-2fde-4e28-97bb-381ac3b8635f", "f1084064-30e8-4b38-8440-70976fdbe8ad", "Admin", "ADMIN" });
        }
    }
}
