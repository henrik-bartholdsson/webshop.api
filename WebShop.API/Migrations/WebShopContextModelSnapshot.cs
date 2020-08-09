﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShop.API.Models;

namespace WebShop.API.Migrations
{
    [DbContext(typeof(WebShopContext))]
    partial class WebShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebShop.API.Models.Category", b =>
                {
                    b.Property<int>("PRODUCT_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ACTIVE")
                        .HasColumnType("bit");

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PARENT_ID")
                        .HasColumnType("int");

                    b.Property<int?>("PROJECT_ID")
                        .HasColumnType("int");

                    b.Property<int?>("REDIRECT_TO_ID")
                        .HasColumnType("int");

                    b.Property<int>("SORT_ORDER")
                        .HasColumnType("int");

                    b.Property<string>("TITLE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TYPE_ID")
                        .HasColumnType("int");

                    b.HasKey("PRODUCT_ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("WebShop.API.Models.Cors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Cors");
                });

            modelBuilder.Entity("WebShop.API.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExtraPrice")
                        .HasColumnType("int");

                    b.Property<bool>("ExtraPriceActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
