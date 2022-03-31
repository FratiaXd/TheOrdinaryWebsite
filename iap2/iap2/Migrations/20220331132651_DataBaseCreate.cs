using Microsoft.EntityFrameworkCore.Migrations;

namespace iap2.Migrations
{
    public partial class DataBaseCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImageAlt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImagePage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImagePage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImagePage3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImagePage1Alt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImagePage2Alt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImagePage3Alt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
