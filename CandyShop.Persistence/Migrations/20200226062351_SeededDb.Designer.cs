﻿// <auto-generated />
using System;
using CandyShop.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CandyShop.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200226062351_SeededDb")]
    partial class SeededDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CandyShop.Domain.Models.Candy", b =>
                {
                    b.Property<int>("CandyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CandyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            CandyId = 1,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla sit amet nibh eget erat scelerisque rhoncus sed quis nisi.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\chocolateCandy-small.jpg",
                            ImageUrl = "\\images\\chocolateCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Chocolate Candy",
                            Price = 4.95m
                        },
                        new
                        {
                            CandyId = 2,
                            CategoryId = 1,
                            Description = "Sed rutrum libero velit, a imperdiet purus posuere ultricies. Quisque ultrices nulla nec tortor luctus blandit.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\chocolateCandy2-small.jpg",
                            ImageUrl = "\\images\\chocolateCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Assorted Chocolate Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 3,
                            CategoryId = 1,
                            Description = "Phasellus dolor augue, blandit a tincidunt eget, egestas sed lacus. Etiam varius leo nec tortor faucibus luctus.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\chocolateCandy3-small.jpg",
                            ImageUrl = "\\images\\chocolateCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Chocolate Candy",
                            Price = 5.75m
                        },
                        new
                        {
                            CandyId = 4,
                            CategoryId = 2,
                            Description = "Donec tempus, diam quis dictum tincidunt, ex neque rutrum ligula, eget congue nunc lorem eu magna.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\fruitCandy-small.jpg",
                            ImageUrl = "\\images\\fruitCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Fruit Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 5,
                            CategoryId = 2,
                            Description = "Sed at ex placerat, ultrices urna elementum, laoreet ligula. Nullam vitae odio sit amet magna faucibus euismod varius vel tortor.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\fruitCandy2-small.jpg",
                            ImageUrl = "\\images\\fruiteCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Fruit Candy",
                            Price = 7.00m
                        },
                        new
                        {
                            CandyId = 6,
                            CategoryId = 2,
                            Description = "Nulla placerat ante ut eros eleifend sagittis. Nulla facilisi. Praesent maximus libero nec justo lobortis tempus.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\fruitCandy3-small.jpg",
                            ImageUrl = "\\images\\fruitCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Assorted Fruit Candy",
                            Price = 11.25m
                        },
                        new
                        {
                            CandyId = 7,
                            CategoryId = 3,
                            Description = "Cras in magna eget velit mollis fringilla sed sed est. In felis massa, volutpat sed iaculis sit amet, eleifend aliquam nisi.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\gummyCandy-small.jpg",
                            ImageUrl = "\\images\\gummyCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Gummy Candy",
                            Price = 3.95m
                        },
                        new
                        {
                            CandyId = 8,
                            CategoryId = 3,
                            Description = "In fermentum ex vitae semper facilisis. Aenean fringilla sagittis arcu, vel posuere justo bibendum eu.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\gummyCandy2-small.jpg",
                            ImageUrl = "\\images\\gummyCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Assorted Assorted Gummy Candy",
                            Price = 1.95m
                        },
                        new
                        {
                            CandyId = 9,
                            CategoryId = 3,
                            Description = "Vestibulum venenatis porttitor ipsum. Vestibulum ac tincidunt ex. Sed convallis turpis quis enim varius, id dignissim dui eleifend.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\gummyCandy3-small.jpg",
                            ImageUrl = "\\images\\gummyCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Gummy Candy",
                            Price = 13.95m
                        },
                        new
                        {
                            CandyId = 10,
                            CategoryId = 4,
                            Description = "Morbi eu justo sed nulla suscipit consectetur ut a ligula. Fusce eu lorem quis lorem vulputate porta.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\halloweenCandy-small.jpg",
                            ImageUrl = "\\images\\halloweenCandy.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Halloween Candy",
                            Price = 1.95m
                        },
                        new
                        {
                            CandyId = 11,
                            CategoryId = 4,
                            Description = "Aenean eu enim tincidunt, porttitor magna quis, lacinia neque. Vestibulum erat enim, porttitor eget arcu et, fringilla lacinia lectus.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\halloweenCandy2-small.jpg",
                            ImageUrl = "\\images\\halloweenCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Assorted Halloween Candy",
                            Price = 12.95m
                        },
                        new
                        {
                            CandyId = 12,
                            CategoryId = 4,
                            Description = "Phasellus quis quam lorem. Nulla et eros malesuada, blandit lorem ac, pellentesque magna.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\halloweenCandy3-small.jpg",
                            ImageUrl = "\\images\\halloweenCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Halloween Candy",
                            Price = 21.95m
                        },
                        new
                        {
                            CandyId = 13,
                            CategoryId = 5,
                            Description = "Sed metus libero, maximus placerat maximus in, elementum non velit. In vel nibh massa. Ut ultricies ut mauris eget venenatis.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\hardCandy-small.jpg",
                            ImageUrl = "\\images\\hardCandy.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Hard Candy",
                            Price = 6.95m
                        },
                        new
                        {
                            CandyId = 14,
                            CategoryId = 5,
                            Description = "Proin consequat dapibus nunc non tempus. Cras maximus, mauris ac ullamcorper dignissim, est tellus accumsan mauris, id semper augue erat eu ex.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\hardCandy2-small.jpg",
                            ImageUrl = "\\images\\hardCandy2.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "Another Hard Candy",
                            Price = 2.95m
                        },
                        new
                        {
                            CandyId = 15,
                            CategoryId = 5,
                            Description = "Nulla luctus euismod nunc eget pretium. Suspendisse mollis ultrices erat, imperdiet accumsan mi blandit et. Integer laoreet eget sem a suscipit.",
                            ImageThumbnailUrl = "\\images\\thumbnails\\hardCandy3-small.jpg",
                            ImageUrl = "\\images\\hardeCandy3.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Best Hard Candy",
                            Price = 16.95m
                        });
                });

            modelBuilder.Entity("CandyShop.Domain.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Chocolate Candy"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruit Candy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Gummy Candy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Halloween Candy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Hard Candy"
                        });
                });

            modelBuilder.Entity("CandyShop.Domain.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CandyShop.Domain.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CandyId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CandyId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("CandyShop.Domain.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("CandyId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("CandyId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("CandyShop.Domain.Models.Candy", b =>
                {
                    b.HasOne("CandyShop.Domain.Models.Category", "Category")
                        .WithMany("Candies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandyShop.Domain.Models.OrderDetail", b =>
                {
                    b.HasOne("CandyShop.Domain.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CandyShop.Domain.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CandyShop.Domain.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("CandyShop.Domain.Models.Candy", "Candy")
                        .WithMany()
                        .HasForeignKey("CandyId");
                });
#pragma warning restore 612, 618
        }
    }
}
