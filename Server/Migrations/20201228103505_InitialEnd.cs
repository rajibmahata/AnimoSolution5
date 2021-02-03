using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimoWeb.Server.Migrations
{
    public partial class InitialEnd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Poster",
                table: "Projects",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GlobalConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirmaName = table.Column<string>(type: "TEXT", nullable: true),
                    FirmaZip = table.Column<string>(type: "TEXT", nullable: true),
                    LandeId = table.Column<int>(type: "INTEGER", nullable: false),
                    FirmaPhone1 = table.Column<string>(type: "TEXT", nullable: true),
                    FirmaPhone2 = table.Column<string>(type: "TEXT", nullable: true),
                    FirmaEmail = table.Column<string>(type: "TEXT", nullable: true),
                    FirmaWeb = table.Column<string>(type: "TEXT", nullable: true),
                    FirmaHost = table.Column<string>(type: "TEXT", nullable: true),
                    FirmaSmtp = table.Column<string>(type: "TEXT", nullable: true),
                    FirmaSmtpUser = table.Column<string>(type: "TEXT", nullable: true),
                    FirmaSmtpPass = table.Column<string>(type: "TEXT", nullable: true),
                    FirmaSmtpPort = table.Column<int>(type: "INTEGER", nullable: false),
                    isPublished = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Graphs",
                columns: table => new
                {
                    GraphId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GraphName = table.Column<string>(type: "TEXT", nullable: true),
                    GraphUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Graphs", x => x.GraphId);
                });

            migrationBuilder.CreateTable(
                name: "MimeTypes",
                columns: table => new
                {
                    MimeTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MimeTypeName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MimeTypes", x => x.MimeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tittle = table.Column<string>(type: "TEXT", nullable: true),
                    Body = table.Column<string>(type: "TEXT", nullable: true),
                    Tags = table.Column<string>(type: "TEXT", nullable: true),
                    Doc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Dlu = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    VideoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    LinkUrl = table.Column<string>(type: "TEXT", nullable: true),
                    isActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                });

            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    SocialId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SocialIconUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.SocialId);
                });

            migrationBuilder.CreateTable(
                name: "Downloads",
                columns: table => new
                {
                    DownloadId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Doc = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Dlu = table.Column<DateTime>(type: "TEXT", nullable: false),
                    isPassworded = table.Column<bool>(type: "INTEGER", nullable: false),
                    MimeTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    FileUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Order = table.Column<int>(type: "INTEGER", nullable: false),
                    isActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Downloads", x => x.DownloadId);
                    table.ForeignKey(
                        name: "FK_Downloads_MimeTypes_MimeTypeId",
                        column: x => x.MimeTypeId,
                        principalTable: "MimeTypes",
                        principalColumn: "MimeTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsGraphs",
                columns: table => new
                {
                    NewsId = table.Column<int>(type: "INTEGER", nullable: false),
                    GraphId = table.Column<int>(type: "INTEGER", nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsGraphs", x => new { x.NewsId, x.GraphId });
                    table.ForeignKey(
                        name: "FK_NewsGraphs_Graphs_GraphId",
                        column: x => x.GraphId,
                        principalTable: "Graphs",
                        principalColumn: "GraphId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsGraphs_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "NewsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialLinks",
                columns: table => new
                {
                    GlobalConfigId = table.Column<int>(type: "INTEGER", nullable: false),
                    SocialId = table.Column<int>(type: "INTEGER", nullable: false),
                    SocialUrlTarget = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialLinks", x => new { x.SocialId, x.GlobalConfigId });
                    table.ForeignKey(
                        name: "FK_SocialLinks_GlobalConfig_GlobalConfigId",
                        column: x => x.GlobalConfigId,
                        principalTable: "GlobalConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SocialLinks_Socials_SocialId",
                        column: x => x.SocialId,
                        principalTable: "Socials",
                        principalColumn: "SocialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Downloads_MimeTypeId",
                table: "Downloads",
                column: "MimeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsGraphs_GraphId",
                table: "NewsGraphs",
                column: "GraphId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialLinks_GlobalConfigId",
                table: "SocialLinks",
                column: "GlobalConfigId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Downloads");

            migrationBuilder.DropTable(
                name: "NewsGraphs");

            migrationBuilder.DropTable(
                name: "SocialLinks");

            migrationBuilder.DropTable(
                name: "MimeTypes");

            migrationBuilder.DropTable(
                name: "Graphs");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "GlobalConfig");

            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.DropColumn(
                name: "Poster",
                table: "Projects");
        }
    }
}
