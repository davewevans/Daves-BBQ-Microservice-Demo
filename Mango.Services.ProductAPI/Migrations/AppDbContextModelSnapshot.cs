﻿// <auto-generated />
using Mango.Services.ProductAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mango.Services.ProductAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mango.Services.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLocalPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 13,
                            CategoryName = "Appetizer",
                            Description = "Tender chicken wings smoked to perfection and tossed in your choice of sauce: Classic BBQ, Honey Mustard, or Spicy Buffalo. Served with celery sticks and blue cheese dip.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/smoked-wings.jpeg",
                            Name = "Smoked Wings",
                            Price = 15.99
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryName = "Appetizer",
                            Description = "Three mini buns filled with slow-smoked pulled pork, topped with our signature BBQ sauce and coleslaw.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/pulled-pork-sliders.jpeg",
                            Name = "BBQ Pulled Pork Sliders",
                            Price = 13.99
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryName = "Appetizer",
                            Description = "Crispy tortilla chips layered with smoked brisket, melted cheddar, jalapeños, sour cream, and pico de gallo.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/loaded-bbq-nachos.jpeg",
                            Name = "Loaded BBQ Nachos",
                            Price = 13.99
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryName = "Appetizer",
                            Description = "Sweet and savory cornbread muffins served with honey butter.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/cornbread-muffins.jpeg",
                            Name = "Cornbread Muffins",
                            Price = 12.99
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryName = "Entree",
                            Description = "Slow-smoked brisket, sliced thin and served with our house BBQ sauce.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/smoked-brisket.jpeg",
                            Name = "Smoked Brisket",
                            Price = 18.989999999999998
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryName = "Entree",
                            Description = "Half rack of tender baby back ribs, glazed with our signature BBQ sauce.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/baby-back-ribs.jpg",
                            Name = "Baby Back Ribs",
                            Price = 17.989999999999998
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryName = "Entree",
                            Description = "Smoked pork shoulder, pulled and served with a side of our tangy BBQ sauce. ",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/pulled-pork-plate.jpeg",
                            Name = "Pulled Pork Plate",
                            Price = 14.99
                        },
                        new
                        {
                            ProductId = 20,
                            CategoryName = "Entree",
                            Description = "Half a chicken, grilled and basted in our BBQ sauce, finished with a smoky flavor.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/grilled-bbq-chicken.jpeg",
                            Name = "Grilled BBQ Chicken",
                            Price = 14.99
                        },
                        new
                        {
                            ProductId = 21,
                            CategoryName = "Entree",
                            Description = "Grilled portobello mushrooms, zucchini, and bell peppers served with quinoa salad.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/vegetarian-bbq-platter.jpeg",
                            Name = "Vegetarian BBQ Platter",
                            Price = 13.99
                        },
                        new
                        {
                            ProductId = 22,
                            CategoryName = "Dessert",
                            Description = "Classic banana pudding topped with vanilla wafers and whipped cream.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/banana-pudding.jpeg",
                            Name = "Banana Pudding",
                            Price = 5.9900000000000002
                        },
                        new
                        {
                            ProductId = 23,
                            CategoryName = "Dessert",
                            Description = "Rich chocolate brownie served with chocolate sauce and whipped cream.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/chocolate-fudge-brownie.jpeg",
                            Name = "Chocolate Fudge Brownie",
                            Price = 5.9900000000000002
                        },
                        new
                        {
                            ProductId = 24,
                            CategoryName = "Dessert",
                            Description = "Warm peach cobbler topped with a scoop of vanilla ice cream.",
                            ImageUrl = "https://d2wdevstorage.blob.core.windows.net/d2wdevblob/peach-cobbler.jpeg",
                            Name = "Peach Cobbler",
                            Price = 6.9900000000000002
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
