using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaNet.WebApi.Migrations
{
    public partial class InitialMigratio4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "Order",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Order");
        }
    }
}
