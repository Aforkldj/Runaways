using Microsoft.EntityFrameworkCore.Migrations;

namespace Runaways.Data.Migrations
{
    public partial class ChangedResortTypePropertyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "ResortTypes");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ResortTypes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ResortTypeId",
                table: "Resorts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "ResortTypes");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "ResortTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ResortTypeId",
                table: "Resorts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
