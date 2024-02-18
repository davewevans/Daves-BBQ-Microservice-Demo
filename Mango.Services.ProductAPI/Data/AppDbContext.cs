using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 13,
                Name = "Smoked Wings",
                Price = 15.99,
                Description = "Tender chicken wings smoked to perfection and tossed in your choice of sauce: Classic BBQ, Honey Mustard, or Spicy Buffalo. Served with celery sticks and blue cheese dip.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/smoked-wings.jpeg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 14,
                Name = "BBQ Pulled Pork Sliders",
                Price = 13.99,
                Description = "Three mini buns filled with slow-smoked pulled pork, topped with our signature BBQ sauce and coleslaw.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/pulled-pork-sliders.jpeg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 15,
                Name = "Loaded BBQ Nachos",
                Price = 13.99,
                Description = "Crispy tortilla chips layered with smoked brisket, melted cheddar, jalapeños, sour cream, and pico de gallo.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/loaded-bbq-nachos.jpeg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 16,
                Name = "Cornbread Muffins",
                Price = 12.99,
                Description = "Sweet and savory cornbread muffins served with honey butter.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/cornbread-muffins.jpeg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 17,
                Name = "Smoked Brisket",
                Price = 18.99,
                Description = "Slow-smoked brisket, sliced thin and served with our house BBQ sauce.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/smoked-brisket.jpeg",
                CategoryName = "Entree"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 18,
                Name = "Baby Back Ribs",
                Price = 17.99,
                Description = "Half rack of tender baby back ribs, glazed with our signature BBQ sauce.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/baby-back-ribs.jpg",
                CategoryName = "Entree"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 19,
                Name = "Pulled Pork Plate",
                Price = 14.99,
                Description = "Smoked pork shoulder, pulled and served with a side of our tangy BBQ sauce. ",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/pulled-pork-plate.jpeg",
                CategoryName = "Entree"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 20,
                Name = "Grilled BBQ Chicken",
                Price = 14.99,
                Description = "Half a chicken, grilled and basted in our BBQ sauce, finished with a smoky flavor.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/grilled-bbq-chicken.jpeg",
                CategoryName = "Entree"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 21,
                Name = "Vegetarian BBQ Platter",
                Price = 13.99,
                Description = "Grilled portobello mushrooms, zucchini, and bell peppers served with quinoa salad.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/vegetarian-bbq-platter.jpeg",
                CategoryName = "Entree"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 22,
                Name = "Banana Pudding",
                Price = 5.99,
                Description = "Classic banana pudding topped with vanilla wafers and whipped cream.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/banana-pudding.jpeg",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 23,
                Name = "Chocolate Fudge Brownie",
                Price = 5.99,
                Description = "Rich chocolate brownie served with chocolate sauce and whipped cream.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/chocolate-fudge-brownie.jpeg",
                CategoryName = "Dessert"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 24,
                Name = "Peach Cobbler",
                Price = 6.99,
                Description = "Warm peach cobbler topped with a scoop of vanilla ice cream.",
                ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/peach-cobbler.jpeg",
                CategoryName = "Dessert"
            });
        }
    }
}
