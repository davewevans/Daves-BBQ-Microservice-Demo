using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mango.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { "Tender chicken wings smoked to perfection and tossed in your choice of sauce: Classic BBQ, Honey Mustard, or Spicy Buffalo. Served with celery sticks and blue cheese dip.", "Smoked Wings", 15.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Three mini buns filled with slow-smoked pulled pork, topped with our signature BBQ sauce and coleslaw.", "BBQ Pulled Pork Sliders" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Appetizer", "Crispy tortilla chips layered with smoked brisket, melted cheddar, jalapeños, sour cream, and pico de gallo.", "https://placehold.co/602x402", "BBQ Pulled Pork Sliders", 13.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Appetizer", "Sweet and savory cornbread muffins served with honey butter.", "https://placehold.co/602x402", "Cornbread Muffins", 12.99 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageLocalPath", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Name", "Price" },
                values: new object[] { " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", "Samosa", 15.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", "Paneer Tikka" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Dessert", " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://placehold.co/601x401", "Sweet Pie", 10.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Entree", " Quisque vel lacus ac magna, vehicula sagittis ut non lacus.<br/> Vestibulum arcu turpis, maximus malesuada neque. Phasellus commodo cursus pretium.", "https://placehold.co/600x400", "Pav Bhaji", 15.0 });
        }
    }
}
