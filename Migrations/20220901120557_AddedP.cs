using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LabAspMvc.Migrations
{
    public partial class AddedP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pic",
                table: "Phones",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created",
                table: "Phones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "edited",
                table: "Phones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pic",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "created",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "edited",
                table: "Phones");
        }
    }
}
