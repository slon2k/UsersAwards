using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Awards",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Microsoft Most Valuable Professional", "MVP" },
                    { 2, "Microsoft Certified Application Developer", "MCAD" },
                    { 3, "Microsoft Certified Solution Developer", "MCSD" },
                    { 4, "Microsoft Certified Systems Engineer", "MCSE" },
                    { 5, "Microsoft Certified Database Administrator", "MCDBA" },
                    { 6, "Microsoft Certified IT Professional", "MCITP" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1958, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bill", "Gates" },
                    { 2, new DateTime(1960, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Severus", "Snape" },
                    { 3, new DateTime(1965, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arthur", "Weasley" },
                    { 4, new DateTime(1980, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Draco", "Malfoy" },
                    { 5, new DateTime(1980, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ginny", "Weasley" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Awards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
