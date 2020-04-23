using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector2.Data.Migrations
{
    public partial class controllersMade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60fa405d-3de7-4e6b-8fe5-a675f65a9072");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<int>(nullable: false),
                    CityName = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zipcode = table.Column<int>(nullable: false),
                    PickupDay = table.Column<string>(nullable: true),
                    OneTimePickup = table.Column<DateTime>(nullable: false),
                    TempSuspendStart = table.Column<DateTime>(nullable: false),
                    TempSuspendEnd = table.Column<DateTime>(nullable: false),
                    AmountOwed = table.Column<double>(nullable: false),
                    PickupConfirmed = table.Column<bool>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNumber = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    EmployeeZipCode = table.Column<int>(nullable: false),
                    IdentityEmployeeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_AspNetUsers_IdentityEmployeeId",
                        column: x => x.IdentityEmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0470c734-f330-4c24-b6f7-a6731c70a539", "37b11827-dc6f-4e29-b663-9ae91d5ae31b", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_IdentityEmployeeId",
                table: "Employee",
                column: "IdentityEmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0470c734-f330-4c24-b6f7-a6731c70a539");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60fa405d-3de7-4e6b-8fe5-a675f65a9072", "50ec6342-b7e6-4cec-ab70-b327e65a6d79", "Admin", "ADMIN" });
        }
    }
}
