using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class Images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Awards",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ImageId",
                table: "Users",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Awards_ImageId",
                table: "Awards",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Awards_Images_ImageId",
                table: "Awards",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Images_ImageId",
                table: "Users",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Awards_Images_ImageId",
                table: "Awards");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Images_ImageId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ImageId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Awards_ImageId",
                table: "Awards");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Awards");
        }
    }
}
