﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using e_shop_backend_esense.Data;

#nullable disable

namespace e_shop_backend_esense.Migrations
{
    [DbContext(typeof(EShopDbContext))]
    [Migration("20230204124351_seed_categories_tbl_2")]
    partial class seed_categories_tbl_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("e_shop_backend_esense.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cars"
                        },
                        new
                        {
                            Id = 11,
                            Name = "BMW",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            Id = 12,
                            Name = "Honda",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            Id = 13,
                            Name = "Toyouta",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            Id = 23,
                            Name = "Lexus",
                            ParentCategoryId = 13
                        },
                        new
                        {
                            Id = 14,
                            Name = "Mercedes",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            Id = 24,
                            Name = "Maybach",
                            ParentCategoryId = 14
                        },
                        new
                        {
                            Id = 25,
                            Name = "Benz",
                            ParentCategoryId = 14
                        },
                        new
                        {
                            Id = 26,
                            Name = "AMG",
                            ParentCategoryId = 14
                        },
                        new
                        {
                            Id = 2,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Laptops",
                            ParentCategoryId = 2
                        },
                        new
                        {
                            Id = 27,
                            Name = "HP",
                            ParentCategoryId = 15
                        },
                        new
                        {
                            Id = 28,
                            Name = "Acer",
                            ParentCategoryId = 15
                        },
                        new
                        {
                            Id = 29,
                            Name = "Dell",
                            ParentCategoryId = 15
                        },
                        new
                        {
                            Id = 17,
                            Name = "Monitors",
                            ParentCategoryId = 2
                        },
                        new
                        {
                            Id = 30,
                            Name = "LG",
                            ParentCategoryId = 17
                        },
                        new
                        {
                            Id = 31,
                            Name = "Samsung",
                            ParentCategoryId = 17
                        },
                        new
                        {
                            Id = 16,
                            Name = "PC",
                            ParentCategoryId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Phones"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Apple",
                            ParentCategoryId = 3
                        },
                        new
                        {
                            Id = 22,
                            Name = "Huawei",
                            ParentCategoryId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Clouthes"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Men",
                            ParentCategoryId = 4
                        },
                        new
                        {
                            Id = 19,
                            Name = "Women",
                            ParentCategoryId = 4
                        },
                        new
                        {
                            Id = 20,
                            Name = "Kid",
                            ParentCategoryId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Books"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Books Sub-Category 1",
                            ParentCategoryId = 5
                        },
                        new
                        {
                            Id = 7,
                            Name = "Books Sub-Category 2",
                            ParentCategoryId = 5
                        },
                        new
                        {
                            Id = 8,
                            Name = "Category 3"
                        });
                });

            modelBuilder.Entity("e_shop_backend_esense.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStuck")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OldPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("e_shop_backend_esense.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("e_shop_backend_esense.Models.Category", b =>
                {
                    b.HasOne("e_shop_backend_esense.Models.Category", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentCategoryId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("e_shop_backend_esense.Models.Product", b =>
                {
                    b.HasOne("e_shop_backend_esense.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("e_shop_backend_esense.Models.Review", b =>
                {
                    b.HasOne("e_shop_backend_esense.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("e_shop_backend_esense.Models.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("e_shop_backend_esense.Models.Product", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}