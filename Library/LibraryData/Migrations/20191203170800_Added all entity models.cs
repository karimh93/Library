using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class Addedallentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "LibraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISBM",
                table: "LibraryAssets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Index",
                table: "LibraryAssets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "ISBM",
                table: "LibraryAssets");

            migrationBuilder.DropColumn(
                name: "Index",
                table: "LibraryAssets");
        }
    }
}
