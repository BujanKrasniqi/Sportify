﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(SportifyDbContext))]
    [Migration("20250112221717_AddReviewEntity")]
    partial class AddReviewEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductBrandId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Description = "Designed for professional as well as amateur badminton players...",
                            Name = "Adidas Quick Force Indoor Badminton Shoes",
                            PictureUrl = "images/products/adidas_shoe-1.png",
                            Price = 3500m,
                            ProductBrandId = -1,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -2,
                            Description = "Designed for professional as well as amateur badminton players...",
                            Name = "Adidas Quick Force Indoor Badminton Shoes",
                            PictureUrl = "images/products/adidas_shoe-2.png",
                            Price = 3375m,
                            ProductBrandId = -1,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -3,
                            Description = "Designed for professional as well as amateur badminton players...",
                            Name = "Adidas Quick Force Indoor Badminton Shoes",
                            PictureUrl = "images/products/adidas_shoe-3.png",
                            Price = 3375m,
                            ProductBrandId = -1,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -4,
                            Description = "The Asics Gel Rocket 8 Indoor Court Shoes...",
                            Name = "Asics Gel Rocket 8 Indoor Court Shoes",
                            PictureUrl = "images/products/asics_shoe-1.png",
                            Price = 4249m,
                            ProductBrandId = -2,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -5,
                            Description = "The Asics Gel Rocket 8 Indoor Court Shoes...",
                            Name = "Asics Gel Rocket 8 Indoor Court Shoes",
                            PictureUrl = "images/products/asics_shoe-2.png",
                            Price = 3499m,
                            ProductBrandId = -2,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -6,
                            Description = "The Asics Gel Rocket 8 Indoor Court Shoes...",
                            Name = "Asics Gel Rocket 8 Indoor Court Shoes",
                            PictureUrl = "images/products/asics_shoe-3.png",
                            Price = 3499m,
                            ProductBrandId = -2,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -7,
                            Description = "PU Leather, Mesh, EVA, ENERGY MAX, Nylon sheet, Rubber",
                            Name = "Victor SHW503 F Badminton Shoes",
                            PictureUrl = "images/products/victor_shoe-1.png",
                            Price = 2392m,
                            ProductBrandId = -3,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -8,
                            Description = "PU Leather, Mesh, EVA, ENERGY MAX, Nylon sheet, Rubber",
                            Name = "Victor SHW503 F Badminton Shoes",
                            PictureUrl = "images/products/victor_shoe-2.png",
                            Price = 3000m,
                            ProductBrandId = -3,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -9,
                            Description = "Rule the game with Super Ace Light...",
                            Name = "YONEX Super Ace Light Badminton Shoes",
                            PictureUrl = "images/products/yonex_shoe-1.png",
                            Price = 2590m,
                            ProductBrandId = -4,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -10,
                            Description = "Rule the game with Super Ace Light...",
                            Name = "YONEX Super Ace Light Badminton Shoes",
                            PictureUrl = "images/products/yonex_shoe-2.png",
                            Price = 3500m,
                            ProductBrandId = -4,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -11,
                            Description = "Rule the game with Super Ace Light...",
                            Name = "YONEX Super Ace Light Badminton Shoes",
                            PictureUrl = "images/products/yonex_shoe-3.png",
                            Price = 3700m,
                            ProductBrandId = -4,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -12,
                            Description = "With features and functions designed to withstand long hours...",
                            Name = "Puma 19 FH Rubber Spike Cricket Shoes",
                            PictureUrl = "images/products/puma_shoe-1.png",
                            Price = 4999m,
                            ProductBrandId = -5,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -13,
                            Description = "With features and functions designed to withstand long hours...",
                            Name = "Puma 19 FH Rubber Spike Cricket Shoes",
                            PictureUrl = "images/products/puma_shoe-2.png",
                            Price = 5200m,
                            ProductBrandId = -5,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -14,
                            Description = "With features and functions designed to withstand long hours...",
                            Name = "Puma 19 FH Rubber Spike Cricket Shoes",
                            PictureUrl = "images/products/puma_shoe-3.png",
                            Price = 5700m,
                            ProductBrandId = -5,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -15,
                            Description = "Babolat Shadow Spirit Mens Badminton Shoes...",
                            Name = "Babolat Shadow Spirit Mens Badminton Shoes",
                            PictureUrl = "images/products/babolat_shoe-1.png",
                            Price = 4125m,
                            ProductBrandId = -7,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -16,
                            Description = "Babolat Shadow Tour Mens Badminton Shoes...",
                            Name = "Babolat Shadow Tour Mens Badminton Shoes",
                            PictureUrl = "images/products/babolat_shoe-2.png",
                            Price = 5249m,
                            ProductBrandId = -7,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -17,
                            Description = "Babolat Shadow Team Womens Badminton Shoes...",
                            Name = "Babolat Shadow Team Womens Badminton Shoes",
                            PictureUrl = "images/products/babolat_shoe-3.png",
                            Price = 2999m,
                            ProductBrandId = -7,
                            ProductTypeId = -1,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -18,
                            Description = "For offensive players looking to win with game-changing spin...",
                            Name = "Yonex VCORE Pro 100 A Tennis Racquet",
                            PictureUrl = "images/products/yonex_racket-1.png",
                            Price = 6099m,
                            ProductBrandId = -4,
                            ProductTypeId = -2,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -19,
                            Description = "For offensive players looking to win with game-changing spin...",
                            Name = "Yonex VCORE Pro 100 A Tennis Racquet",
                            PictureUrl = "images/products/yonex_racket-2.png",
                            Price = 6399m,
                            ProductBrandId = -4,
                            ProductTypeId = -2,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -20,
                            Description = "For offensive players looking to win with game-changing spin...",
                            Name = "Yonex VCORE Pro 100 2019 Tennis Racquet",
                            PictureUrl = "images/products/yonex_racket-3.png",
                            Price = 13299m,
                            ProductBrandId = -4,
                            ProductTypeId = -2,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -21,
                            Description = "Babolat Boost D Tennis Racquet...",
                            Name = "Babolat Boost D Tennis Racquet",
                            PictureUrl = "images/products/babolat_racket-1.png",
                            Price = 6999m,
                            ProductBrandId = -7,
                            ProductTypeId = -2,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -22,
                            Description = "Babolat Pure Aero 2019 Superlite Tennis Racquet...",
                            Name = "Buy Babolat Pure Aero 2019 Superlite Tennis Racquet...",
                            PictureUrl = "images/products/babolat_racket-2.png",
                            Price = 13000m,
                            ProductBrandId = -7,
                            ProductTypeId = -2,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -23,
                            Description = "Babolat Pure Drive VS Tennis Racquet...",
                            Name = "Babolat Pure Drive VS Tennis Racquet",
                            PictureUrl = "images/products/babolat_racket-3.png",
                            Price = 34000m,
                            ProductBrandId = -7,
                            ProductTypeId = -2,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -24,
                            Description = "Featuring an innovative surface panel design...",
                            Name = "Adidas FIFA World Cup 2018 OMB Football",
                            PictureUrl = "images/products/adidas_football-1.png",
                            Price = 2499m,
                            ProductBrandId = -1,
                            ProductTypeId = -3,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -25,
                            Description = "Featuring an innovative surface panel design...",
                            Name = "Adidas FIFA World Cup 2018 OMB Football",
                            PictureUrl = "images/products/adidas_football-2.png",
                            Price = 3200m,
                            ProductBrandId = -1,
                            ProductTypeId = -3,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -26,
                            Description = "Featuring an innovative surface panel design...",
                            Name = "Adidas FIFA World Cup Top Glider Ball",
                            PictureUrl = "images/products/adidas_football-3.png",
                            Price = 2499m,
                            ProductBrandId = -1,
                            ProductTypeId = -3,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -27,
                            Description = "Nike Pitch Premier League Football...",
                            Name = "Nike Pitch Premier League Football",
                            PictureUrl = "images/products/Nike_Football-1.png",
                            Price = 1525m,
                            ProductBrandId = -6,
                            ProductTypeId = -3,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -28,
                            Description = "Nike Manchester City Supporters Football...",
                            Name = "Nike Manchester City Supporters Football",
                            PictureUrl = "images/products/Nike_Football-2.png",
                            Price = 1525m,
                            ProductBrandId = -6,
                            ProductTypeId = -3,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -29,
                            Description = "Nike Mercurial Veer Football...",
                            Name = "Nike Mercurial Veer Football",
                            PictureUrl = "images/products/Nike_Football-3.png",
                            Price = 1450m,
                            ProductBrandId = -6,
                            ProductTypeId = -3,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -30,
                            Description = "The Babolat Team Line racquet bag is highly durable...",
                            Name = "Babolat Team Line Racket 12 Kit Bag",
                            PictureUrl = "images/products/babolat_kitback-1.png",
                            Price = 4550m,
                            ProductBrandId = -7,
                            ProductTypeId = -4,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -31,
                            Description = "Babolat Pure Strike RH X12 Kit Bag...",
                            Name = "Babolat Pure Strike RH X12 Kit Bag",
                            PictureUrl = "images/products/babolat_kitback-2.png",
                            Price = 9799m,
                            ProductBrandId = -7,
                            ProductTypeId = -4,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -32,
                            Description = "Babolat Team Line 12 Racquet Kit Bag...",
                            Name = "Babolat Team Line 12 Racquet Kit Bag",
                            PictureUrl = "images/products/babolat_kitback-3.png",
                            Price = 4550m,
                            ProductBrandId = -7,
                            ProductTypeId = -4,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -33,
                            Description = "Yonex SUNR 4826TK BT6-SR Badminton Kit Bag...",
                            Name = "Yonex SUNR 4826TK BT6-SR Badminton Kit Bag",
                            PictureUrl = "images/products/yonex_kitback-1.png",
                            Price = 1999m,
                            ProductBrandId = -4,
                            ProductTypeId = -4,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -34,
                            Description = "Yonex SUNR LRB05 MS BT6 S Badminton Kit Bag...",
                            Name = "Yonex SUNR LRB05 MS BT6 S Badminton Kit Bag",
                            PictureUrl = "images/products/yonex_kitback-2.png",
                            Price = 1499m,
                            ProductBrandId = -4,
                            ProductTypeId = -4,
                            StockQuantity = 0
                        },
                        new
                        {
                            Id = -35,
                            Description = "Yonex SUNR LRB05 MS BT6 S Badminton Kit Bag...",
                            Name = "Yonex SUNR LRB05 MS BT6 S Badminton Kit Bag",
                            PictureUrl = "images/products/yonex_kitback-3.png",
                            Price = 1499m,
                            ProductBrandId = -4,
                            ProductTypeId = -4,
                            StockQuantity = 0
                        });
                });

            modelBuilder.Entity("Core.Entities.ProductBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductBrands");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "Adidas"
                        },
                        new
                        {
                            Id = -2,
                            Name = "ASICS"
                        },
                        new
                        {
                            Id = -3,
                            Name = "Victor"
                        },
                        new
                        {
                            Id = -4,
                            Name = "Yonex"
                        },
                        new
                        {
                            Id = -5,
                            Name = "Puma"
                        },
                        new
                        {
                            Id = -6,
                            Name = "Nike"
                        },
                        new
                        {
                            Id = -7,
                            Name = "Babolat"
                        });
                });

            modelBuilder.Entity("Core.Entities.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "Shoes"
                        },
                        new
                        {
                            Id = -2,
                            Name = "Rackets"
                        },
                        new
                        {
                            Id = -3,
                            Name = "Football"
                        },
                        new
                        {
                            Id = -4,
                            Name = "Kit Bags"
                        });
                });

            modelBuilder.Entity("Core.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.HasOne("Core.Entities.ProductBrand", "ProductBrand")
                        .WithMany()
                        .HasForeignKey("ProductBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Core.Entities.Review", b =>
                {
                    b.HasOne("Core.Entities.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Core.Entities.Product", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
