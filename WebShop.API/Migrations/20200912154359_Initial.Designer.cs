﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShop.API.Models;

namespace WebShop.Data.Migrations
{
    [DbContext(typeof(WebShopContext))]
    [Migration("20200912154359_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebShop.API.Models.CATEGORIES", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<bool>("ACTIVE")
                        .HasColumnType("bit");

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PARENT_ID")
                        .HasColumnType("int");

                    b.Property<int?>("REDIRECT_TO_ID")
                        .HasColumnType("int");

                    b.Property<int>("SORT_ORDER")
                        .HasColumnType("int");

                    b.Property<string>("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PARENT_ID");

                    b.ToTable("CATEGORY");
                });

            modelBuilder.Entity("WebShop.API.Models.CORS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ACTIVE")
                        .HasColumnType("bit");

                    b.Property<string>("ADDRESS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COMMENT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CORS");
                });

            modelBuilder.Entity("WebShop.API.Models.PRODUCT", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EXTRA_PRICE")
                        .HasColumnType("int");

                    b.Property<bool>("EXTRA_PRICE_ACTIVE")
                        .HasColumnType("bit");

                    b.Property<string>("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PARENT_CATEGORY_ID")
                        .HasColumnType("int");

                    b.Property<int>("PRICE")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PRODUCT");
                });

            modelBuilder.Entity("WebShop.API.Models.CATEGORIES", b =>
                {
                    b.HasOne("WebShop.API.Models.CATEGORIES", null)
                        .WithMany("SUBCATEGORIES")
                        .HasForeignKey("PARENT_ID");
                });
#pragma warning restore 612, 618
        }
    }
}
