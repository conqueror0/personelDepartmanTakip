using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartman.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "yillikizinhakki",
                table: "personals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "yillikizinhakki",
                table: "personals",
                nullable: false,
                defaultValue: 0);
        }
    }
}
