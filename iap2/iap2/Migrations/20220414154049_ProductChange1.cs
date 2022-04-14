using Microsoft.EntityFrameworkCore.Migrations;

namespace iap2.Migrations
{
    public partial class ProductChange1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ShoppingCartItems_CartItemItemId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartItemItemId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartItemItemId",
                table: "Products");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems");

            migrationBuilder.AddColumn<string>(
                name: "CartItemItemId",
                table: "Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartItemItemId",
                table: "Products",
                column: "CartItemItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ShoppingCartItems_CartItemItemId",
                table: "Products",
                column: "CartItemItemId",
                principalTable: "ShoppingCartItems",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
