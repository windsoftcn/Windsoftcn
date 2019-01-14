using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MP.Migrations
{
    public partial class Update05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeChatBoxApp");

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "WeChatBoxes",
                maxLength: 1024,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WxBoxApp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BoxId = table.Column<int>(nullable: false),
                    AppId = table.Column<int>(nullable: false),
                    AppShowType = table.Column<int>(nullable: true),
                    AppNavigationType = table.Column<int>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WxBoxApp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WxBoxApp_WeChatApps_AppId",
                        column: x => x.AppId,
                        principalTable: "WeChatApps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WxBoxApp_WeChatBoxes_BoxId",
                        column: x => x.BoxId,
                        principalTable: "WeChatBoxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WxBoxApp_AppId",
                table: "WxBoxApp",
                column: "AppId");

            migrationBuilder.CreateIndex(
                name: "IX_WxBoxApp_BoxId",
                table: "WxBoxApp",
                column: "BoxId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WxBoxApp");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "WeChatBoxes");

            migrationBuilder.CreateTable(
                name: "WeChatBoxApp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AppId = table.Column<int>(nullable: false),
                    AppNavigationType = table.Column<int>(nullable: true),
                    AppShowType = table.Column<int>(nullable: true),
                    BoxId = table.Column<int>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatBoxApp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatBoxApp_WeChatApps_AppId",
                        column: x => x.AppId,
                        principalTable: "WeChatApps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeChatBoxApp_WeChatBoxes_BoxId",
                        column: x => x.BoxId,
                        principalTable: "WeChatBoxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeChatBoxApp_AppId",
                table: "WeChatBoxApp",
                column: "AppId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatBoxApp_BoxId",
                table: "WeChatBoxApp",
                column: "BoxId");
        }
    }
}
