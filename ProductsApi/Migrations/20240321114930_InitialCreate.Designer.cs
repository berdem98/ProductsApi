﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsApi.Models;

#nullable disable

namespace ProductsApi.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20240321114930_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.17");

            modelBuilder.Entity("ProductsApi.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            IsActive = true,
                            Price = 15000m,
                            ProductName = "Iphone 10"
                        },
                        new
                        {
                            ProductId = 2,
                            IsActive = true,
                            Price = 25000m,
                            ProductName = "Iphone 11"
                        },
                        new
                        {
                            ProductId = 3,
                            IsActive = true,
                            Price = 35000m,
                            ProductName = "Iphone 12"
                        },
                        new
                        {
                            ProductId = 4,
                            IsActive = false,
                            Price = 45000m,
                            ProductName = "Iphone 13"
                        },
                        new
                        {
                            ProductId = 5,
                            IsActive = true,
                            Price = 55000m,
                            ProductName = "Iphone 14"
                        },
                        new
                        {
                            ProductId = 6,
                            IsActive = true,
                            Price = 65000m,
                            ProductName = "Iphone 15"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
