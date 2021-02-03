using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimoWeb.Server.Migrations
{
    public partial class LucasBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "ProjectImages");

            migrationBuilder.AddColumn<int>(
                name: "order",
                table: "Images",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "order",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ProjectImages",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
