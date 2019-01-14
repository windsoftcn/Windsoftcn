using Microsoft.EntityFrameworkCore.Migrations;

namespace MP.Migrations
{
    public partial class Update06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeChatApps_AppOwners_AppOwnerId",
                table: "WeChatApps");

            migrationBuilder.DropForeignKey(
                name: "FK_WeChatApps_WeChatBoxes_WeChatBoxId",
                table: "WeChatApps");

            migrationBuilder.DropForeignKey(
                name: "FK_WxBoxApp_WeChatApps_AppId",
                table: "WxBoxApp");

            migrationBuilder.DropForeignKey(
                name: "FK_WxBoxApp_WeChatBoxes_BoxId",
                table: "WxBoxApp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WxBoxApp",
                table: "WxBoxApp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeChatBoxes",
                table: "WeChatBoxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeChatApps",
                table: "WeChatApps");

            migrationBuilder.RenameTable(
                name: "WxBoxApp",
                newName: "WxBoxApps");

            migrationBuilder.RenameTable(
                name: "WeChatBoxes",
                newName: "WxBoxes");

            migrationBuilder.RenameTable(
                name: "WeChatApps",
                newName: "WxApps");

            migrationBuilder.RenameIndex(
                name: "IX_WxBoxApp_BoxId",
                table: "WxBoxApps",
                newName: "IX_WxBoxApps_BoxId");

            migrationBuilder.RenameIndex(
                name: "IX_WxBoxApp_AppId",
                table: "WxBoxApps",
                newName: "IX_WxBoxApps_AppId");

            migrationBuilder.RenameIndex(
                name: "IX_WeChatApps_WeChatBoxId",
                table: "WxApps",
                newName: "IX_WxApps_WeChatBoxId");

            migrationBuilder.RenameIndex(
                name: "IX_WeChatApps_AppOwnerId",
                table: "WxApps",
                newName: "IX_WxApps_AppOwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_WeChatApps_AppId",
                table: "WxApps",
                newName: "IX_WxApps_AppId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WxBoxApps",
                table: "WxBoxApps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WxBoxes",
                table: "WxBoxes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WxApps",
                table: "WxApps",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WxApps_AppOwners_AppOwnerId",
                table: "WxApps",
                column: "AppOwnerId",
                principalTable: "AppOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WxApps_WxBoxes_WeChatBoxId",
                table: "WxApps",
                column: "WeChatBoxId",
                principalTable: "WxBoxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WxBoxApps_WxApps_AppId",
                table: "WxBoxApps",
                column: "AppId",
                principalTable: "WxApps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WxBoxApps_WxBoxes_BoxId",
                table: "WxBoxApps",
                column: "BoxId",
                principalTable: "WxBoxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WxApps_AppOwners_AppOwnerId",
                table: "WxApps");

            migrationBuilder.DropForeignKey(
                name: "FK_WxApps_WxBoxes_WeChatBoxId",
                table: "WxApps");

            migrationBuilder.DropForeignKey(
                name: "FK_WxBoxApps_WxApps_AppId",
                table: "WxBoxApps");

            migrationBuilder.DropForeignKey(
                name: "FK_WxBoxApps_WxBoxes_BoxId",
                table: "WxBoxApps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WxBoxes",
                table: "WxBoxes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WxBoxApps",
                table: "WxBoxApps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WxApps",
                table: "WxApps");

            migrationBuilder.RenameTable(
                name: "WxBoxes",
                newName: "WeChatBoxes");

            migrationBuilder.RenameTable(
                name: "WxBoxApps",
                newName: "WxBoxApp");

            migrationBuilder.RenameTable(
                name: "WxApps",
                newName: "WeChatApps");

            migrationBuilder.RenameIndex(
                name: "IX_WxBoxApps_BoxId",
                table: "WxBoxApp",
                newName: "IX_WxBoxApp_BoxId");

            migrationBuilder.RenameIndex(
                name: "IX_WxBoxApps_AppId",
                table: "WxBoxApp",
                newName: "IX_WxBoxApp_AppId");

            migrationBuilder.RenameIndex(
                name: "IX_WxApps_WeChatBoxId",
                table: "WeChatApps",
                newName: "IX_WeChatApps_WeChatBoxId");

            migrationBuilder.RenameIndex(
                name: "IX_WxApps_AppOwnerId",
                table: "WeChatApps",
                newName: "IX_WeChatApps_AppOwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_WxApps_AppId",
                table: "WeChatApps",
                newName: "IX_WeChatApps_AppId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeChatBoxes",
                table: "WeChatBoxes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WxBoxApp",
                table: "WxBoxApp",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeChatApps",
                table: "WeChatApps",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeChatApps_AppOwners_AppOwnerId",
                table: "WeChatApps",
                column: "AppOwnerId",
                principalTable: "AppOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WeChatApps_WeChatBoxes_WeChatBoxId",
                table: "WeChatApps",
                column: "WeChatBoxId",
                principalTable: "WeChatBoxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WxBoxApp_WeChatApps_AppId",
                table: "WxBoxApp",
                column: "AppId",
                principalTable: "WeChatApps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WxBoxApp_WeChatBoxes_BoxId",
                table: "WxBoxApp",
                column: "BoxId",
                principalTable: "WeChatBoxes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
