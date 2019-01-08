using Microsoft.EntityFrameworkCore.Migrations;

namespace MP.Migrations
{
    public partial class Update02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WeChatMiniApps",
                table: "WeChatMiniApps");

            migrationBuilder.RenameTable(
                name: "WeChatMiniApps",
                newName: "WeChatApps");

            migrationBuilder.RenameIndex(
                name: "IX_WeChatMiniApps_AppId",
                table: "WeChatApps",
                newName: "IX_WeChatApps_AppId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeChatApps",
                table: "WeChatApps",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WeChatApps",
                table: "WeChatApps");

            migrationBuilder.RenameTable(
                name: "WeChatApps",
                newName: "WeChatMiniApps");

            migrationBuilder.RenameIndex(
                name: "IX_WeChatApps_AppId",
                table: "WeChatMiniApps",
                newName: "IX_WeChatMiniApps_AppId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeChatMiniApps",
                table: "WeChatMiniApps",
                column: "Id");
        }
    }
}
