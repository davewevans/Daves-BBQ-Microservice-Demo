using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageLocalPath", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 13, "Appetizer", "Tender chicken wings smoked to perfection and tossed in your choice of sauce: Classic BBQ, Honey Mustard, or Spicy Buffalo. Served with celery sticks and blue cheese dip.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/smoked-wings.jpeg", "Smoked Wings", 15.99 },
                    { 14, "Appetizer", "Three mini buns filled with slow-smoked pulled pork, topped with our signature BBQ sauce and coleslaw.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/pulled-pork-sliders.jpeg", "BBQ Pulled Pork Sliders", 13.99 },
                    { 15, "Appetizer", "Crispy tortilla chips layered with smoked brisket, melted cheddar, jalapeños, sour cream, and pico de gallo.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/loaded-bbq-nachos.jpeg", "Loaded BBQ Nachos", 13.99 },
                    { 16, "Appetizer", "Sweet and savory cornbread muffins served with honey butter.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/cornbread-muffins.jpeg", "Cornbread Muffins", 12.99 },
                    { 17, "Entree", "Slow-smoked brisket, sliced thin and served with our house BBQ sauce.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/smoked-brisket.jpeg", "Smoked Brisket", 18.989999999999998 },
                    { 18, "Entree", "Half rack of tender baby back ribs, glazed with our signature BBQ sauce.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/baby-back-ribs.jpg", "Baby Back Ribs", 17.989999999999998 },
                    { 19, "Entree", "Smoked pork shoulder, pulled and served with a side of our tangy BBQ sauce. ", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/pulled-pork-plate.jpeg", "Pulled Pork Plate", 14.99 },
                    { 20, "Entree", "Half a chicken, grilled and basted in our BBQ sauce, finished with a smoky flavor.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/grilled-bbq-chicken.jpeg", "Grilled BBQ Chicken", 14.99 },
                    { 21, "Entree", "Grilled portobello mushrooms, zucchini, and bell peppers served with quinoa salad.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/vegetarian-bbq-platter.jpeg", "Vegetarian BBQ Platter", 13.99 },
                    { 22, "Dessert", "Classic banana pudding topped with vanilla wafers and whipped cream.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/banana-pudding.jpeg", "Banana Pudding", 5.9900000000000002 },
                    { 23, "Dessert", "Rich chocolate brownie served with chocolate sauce and whipped cream.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/chocolate-fudge-brownie.jpeg", "Chocolate Fudge Brownie", 5.9900000000000002 },
                    { 24, "Dessert", "Warm peach cobbler topped with a scoop of vanilla ice cream.", null, "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/peach-cobbler.jpeg", "Peach Cobbler", 6.9900000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageLocalPath", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Tender chicken wings smoked to perfection and tossed in your choice of sauce: Classic BBQ, Honey Mustard, or Spicy Buffalo. Served with celery sticks and blue cheese dip.", null, "https://placehold.co/603x403", "Smoked Wings", 15.99 },
                    { 2, "Appetizer", "Three mini buns filled with slow-smoked pulled pork, topped with our signature BBQ sauce and coleslaw.", null, "https://placehold.co/602x402", "BBQ Pulled Pork Sliders", 13.99 },
                    { 3, "Appetizer", "Crispy tortilla chips layered with smoked brisket, melted cheddar, jalapeños, sour cream, and pico de gallo.", null, "https://placehold.co/602x402", "BBQ Pulled Pork Sliders", 13.99 },
                    { 4, "Appetizer", "Sweet and savory cornbread muffins served with honey butter.", null, "https://placehold.co/602x402", "Cornbread Muffins", 12.99 },
                    { 5, "Entree", "Slow-smoked brisket, sliced thin and served with our house BBQ sauce.", null, "https://placehold.co/600x400", "Smoked Brisket", 18.989999999999998 },
                    { 6, "Entree", "Half rack of tender baby back ribs, glazed with our signature BBQ sauce.", null, "https://placehold.co/600x400", "Baby Back Ribs", 17.989999999999998 },
                    { 7, "Entree", "Smoked pork shoulder, pulled and served with a side of our tangy BBQ sauce. ", null, "https://placehold.co/600x400", "Pulled Pork Plate", 14.99 },
                    { 8, "Entree", "Half a chicken, grilled and basted in our BBQ sauce, finished with a smoky flavor.", null, "https://placehold.co/600x400", "Grilled BBQ Chicken", 14.99 },
                    { 9, "Entree", "Grilled portobello mushrooms, zucchini, and bell peppers served with quinoa salad.", null, "https://placehold.co/600x400", "Vegetarian BBQ Platter", 13.99 },
                    { 10, "Dessert", "Classic banana pudding topped with vanilla wafers and whipped cream.", null, "https://placehold.co/601x401", "Banana Pudding", 5.9900000000000002 },
                    { 11, "Dessert", "Rich chocolate brownie served with chocolate sauce and whipped cream.", null, "https://placehold.co/601x401", "Chocolate Fudge Brownie", 5.9900000000000002 },
                    { 12, "Dessert", "Warm peach cobbler topped with a scoop of vanilla ice cream.", null, "https://placehold.co/601x401", "Peach Cobbler", 6.9900000000000002 }
                });
        }
    }
}
