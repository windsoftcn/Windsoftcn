using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MP.Migrations
{
    public partial class Update04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsEnabled",
                table: "WeChatApps",
                newName: "Enabled");

            migrationBuilder.AlterColumn<string>(
                name: "AppName",
                table: "WeChatApps",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppOwnerId",
                table: "WeChatApps",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeChatBoxId",
                table: "WeChatApps",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppOwners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Phone = table.Column<string>(maxLength: 128, nullable: true),
                    Remark = table.Column<string>(maxLength: 1024, nullable: true),
                    Enabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppOwners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatBoxes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatBoxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatBoxApp",
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
                name: "IX_WeChatApps_AppOwnerId",
                table: "WeChatApps",
                column: "AppOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatApps_WeChatBoxId",
                table: "WeChatApps",
                column: "WeChatBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatBoxApp_AppId",
                table: "WeChatBoxApp",
                column: "AppId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatBoxApp_BoxId",
                table: "WeChatBoxApp",
                column: "BoxId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeChatApps_AppOwners_AppOwnerId",
                table: "WeChatApps");

            migrationBuilder.DropForeignKey(
                name: "FK_WeChatApps_WeChatBoxes_WeChatBoxId",
                table: "WeChatApps");

            migrationBuilder.DropTable(
                name: "AppOwners");

            migrationBuilder.DropTable(
                name: "WeChatBoxApp");

            migrationBuilder.DropTable(
                name: "WeChatBoxes");

            migrationBuilder.DropIndex(
                name: "IX_WeChatApps_AppOwnerId",
                table: "WeChatApps");

            migrationBuilder.DropIndex(
                name: "IX_WeChatApps_WeChatBoxId",
                table: "WeChatApps");

            migrationBuilder.DropColumn(
                name: "AppOwnerId",
                table: "WeChatApps");

            migrationBuilder.DropColumn(
                name: "WeChatBoxId",
                table: "WeChatApps");

            migrationBuilder.RenameColumn(
                name: "Enabled",
                table: "WeChatApps",
                newName: "IsEnabled");

            migrationBuilder.AlterColumn<string>(
                name: "AppName",
                table: "WeChatApps",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);
        }
    }
}
