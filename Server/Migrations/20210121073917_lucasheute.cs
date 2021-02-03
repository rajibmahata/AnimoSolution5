using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimoWeb.Server.Migrations
{
    public partial class lucasheute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bilboards",
                columns: table => new
                {
                    BilboardId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BilboardName = table.Column<string>(type: "TEXT", nullable: true),
                    BilboarFile = table.Column<string>(type: "TEXT", nullable: true),
                    isDefaultActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilboards", x => x.BilboardId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilboards");
        }
    }
}
