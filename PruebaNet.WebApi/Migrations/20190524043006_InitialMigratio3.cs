using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaNet.WebApi.Migrations
{
    public partial class InitialMigratio3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_Id",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_PLU_Id",
                table: "Product");

            migrationBuilder.AlterColumn<long>(
                name: "PLUId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "CategoryId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_PLUId",
                table: "Product",
                column: "PLUId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_PLU_PLUId",
                table: "Product",
                column: "PLUId",
                principalTable: "PLU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_PLU_PLUId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_PLUId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "PLUId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Product",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_Id",
                table: "Product",
                column: "Id",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_PLU_Id",
                table: "Product",
                column: "Id",
                principalTable: "PLU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
