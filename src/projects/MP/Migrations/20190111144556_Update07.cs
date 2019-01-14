using Microsoft.EntityFrameworkCore.Migrations;

namespace MP.Migrations
{
    public partial class Update07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "WxBoxApps",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "WxBoxApps");
        }
    }
}
