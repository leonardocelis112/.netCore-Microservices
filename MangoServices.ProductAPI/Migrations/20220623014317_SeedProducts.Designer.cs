﻿// <auto-generated />
using MangoServices.ProductAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MangoServices.ProductAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220623014317_SeedProducts")]
    partial class SeedProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MangoServices.ProductAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
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
                            ProductId = 1,
                            Category = "Appetizer",
                            Description = "Delicious Chontaduro",
                            ImageUrl = "https://dotnetmasteryleo.blob.core.windows.net/mango/chontaduro.jpeg",
                            Name = "Chontaduro",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Dessert",
                            Description = "Delicious Platano",
                            ImageUrl = "https://dotnetmasteryleo.blob.core.windows.net/mango/platano.jpeg",
                            Name = "Platano",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 3,
                            Category = "Entree",
                            Description = "Delicious Mango",
                            ImageUrl = "https://dotnetmasteryleo.blob.core.windows.net/mango/mango.jpeg",
                            Name = "Mango",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 4,
                            Category = "Dessert",
                            Description = "Delicious Pera",
                            ImageUrl = "https://dotnetmasteryleo.blob.core.windows.net/mango/pera.jpeg",
                            Name = "Pera",
                            Price = 15.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}