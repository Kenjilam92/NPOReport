using Microsoft.EntityFrameworkCore.Migrations;

namespace reportNPO.Migrations
{
    public partial class secondemo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Donation",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Percent",
                table: "Orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Donation",
                table: "Orders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Percent",
                table: "Orders",
                nullable: false,
                defaultValue: 0);
        }
    }
}
