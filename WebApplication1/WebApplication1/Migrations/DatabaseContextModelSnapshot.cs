﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Contexts;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoriesProducts", b =>
                {
                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("IdProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesCategoryId", "IdProductsProductId");

                    b.HasIndex("IdProductsProductId");

                    b.ToTable("CategoriesProducts");
                });

            modelBuilder.Entity("WebApplication1.Models.Accounts", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_account");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccountEmail")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("email");

                    b.Property<string>("AccountFirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("AccountLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("AccountPhone")
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)")
                        .HasColumnName("phone");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("WebApplication1.Models.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_category");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebApplication1.Models.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_product");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<double>("ProductDepth")
                        .HasColumnType("float")
                        .HasColumnName("depth");

                    b.Property<double>("ProductHeight")
                        .HasColumnType("float")
                        .HasColumnName("height");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.Property<double>("ProductWeight")
                        .HasColumnType("float")
                        .HasColumnName("weight");

                    b.Property<double>("ProductWidth")
                        .HasColumnType("float")
                        .HasColumnName("width");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CategoriesProducts", b =>
                {
                    b.HasOne("WebApplication1.Models.Categories", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Products", null)
                        .WithMany()
                        .HasForeignKey("IdProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
