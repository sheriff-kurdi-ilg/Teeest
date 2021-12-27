using Microsoft.EntityFrameworkCore.Migrations;

namespace Teeest.Data.Migrations
{
    public partial class employeedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Db",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Db",
                table: "Employee");
        }
    }
}
