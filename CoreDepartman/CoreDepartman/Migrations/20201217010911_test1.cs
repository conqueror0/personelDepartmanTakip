using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartman.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmanlarid",
                table: "personals",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "iseGirisTarihi",
                table: "personals",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "yillikizinhakki",
                table: "personals",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_personals_departmanlarid",
                table: "personals",
                column: "departmanlarid");

            migrationBuilder.AddForeignKey(
                name: "FK_personals_departmanlars_departmanlarid",
                table: "personals",
                column: "departmanlarid",
                principalTable: "departmanlars",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personals_departmanlars_departmanlarid",
                table: "personals");

            migrationBuilder.DropIndex(
                name: "IX_personals_departmanlarid",
                table: "personals");

            migrationBuilder.DropColumn(
                name: "departmanlarid",
                table: "personals");

            migrationBuilder.DropColumn(
                name: "iseGirisTarihi",
                table: "personals");

            migrationBuilder.DropColumn(
                name: "yillikizinhakki",
                table: "personals");
        }
    }
}
