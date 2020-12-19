using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartman.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "yillikizinhakki",
                table: "personals",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "yillikizinhakki",
                table: "personals",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
