using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MangoServices.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Delicious Chontaduro", "https://dotnetmasteryleo.blob.core.windows.net/mango/chontaduro.jpeg", "Chontaduro", 15.0 },
                    { 2, "Dessert", "Delicious Platano", "https://dotnetmasteryleo.blob.core.windows.net/mango/platano.jpeg", "Platano", 15.0 },
                    { 3, "Entree", "Delicious Mango", "https://dotnetmasteryleo.blob.core.windows.net/mango/mango.jpeg", "Mango", 15.0 },
                    { 4, "Dessert", "Delicious Pera", "https://dotnetmasteryleo.blob.core.windows.net/mango/pera.jpeg", "Pera", 15.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
