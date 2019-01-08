using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MP.Migrations
{
    public partial class Update01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeChatAppCreateViewModel");

            migrationBuilder.DropTable(
                name: "WeChatAppViewModel");

            migrationBuilder.DropTable(
                name: "AppType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatAppCreateViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppAlias = table.Column<string>(nullable: true),
                    AppId = table.Column<string>(nullable: true),
                    AppName = table.Column<string>(nullable: true),
                    AppTypeId = table.Column<int>(nullable: true),
                    BannerUrl = table.Column<string>(nullable: true),
                    CoverUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IconUrl = table.Column<string>(nullable: true),
                    QRUrl = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Secret = table.Column<string>(nullable: true),
                    ShareUrl = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatAppCreateViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatAppCreateViewModel_AppType_AppTypeId",
                        column: x => x.AppTypeId,
                        principalTable: "AppType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeChatAppViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppAlias = table.Column<string>(nullable: true),
                    AppId = table.Column<string>(nullable: true),
                    AppName = table.Column<string>(nullable: true),
                    AppTypeId = table.Column<int>(nullable: true),
                    BannerUrl = table.Column<string>(nullable: true),
                    CoverUrl = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTimeOffset>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IconUrl = table.Column<string>(nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false),
                    QRUrl = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Secret = table.Column<string>(nullable: true),
                    ShareUrl = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatAppViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatAppViewModel_AppType_AppTypeId",
                        column: x => x.AppTypeId,
                        principalTable: "AppType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeChatAppCreateViewModel_AppTypeId",
                table: "WeChatAppCreateViewModel",
                column: "AppTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatAppViewModel_AppTypeId",
                table: "WeChatAppViewModel",
                column: "AppTypeId");
        }
    }
}
