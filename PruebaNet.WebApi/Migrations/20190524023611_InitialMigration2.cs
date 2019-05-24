using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaNet.WebApi.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_OrderId1",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Product_ProductId1",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_OrderId1",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_ProductId1",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "OrderDetail");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "OrderDetail",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<long>(
                name: "OrderId",
                table: "OrderDetail",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Product_ProductId",
                table: "OrderDetail",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Product_ProductId",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetail",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "OrderId1",
                table: "OrderDetail",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProductId1",
                table: "OrderDetail",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId1",
                table: "OrderDetail",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId1",
                table: "OrderDetail",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_OrderId1",
                table: "OrderDetail",
                column: "OrderId1",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Product_ProductId1",
                table: "OrderDetail",
                column: "ProductId1",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
