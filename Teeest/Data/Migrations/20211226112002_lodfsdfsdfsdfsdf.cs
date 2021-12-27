using Microsoft.EntityFrameworkCore.Migrations;

namespace Teeest.Data.Migrations
{
    public partial class lodfsdfsdfsdfsdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Des",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Des",
                table: "Employee");
        }
    }
}
