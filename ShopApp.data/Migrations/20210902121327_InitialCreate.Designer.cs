﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopApp.data.Concrete.EfCore;

namespace ShopApp.data.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20210902121327_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("ShopApp.entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShopApp.entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<double?>("price")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShopApp.entity.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("ShopApp.entity.ProductCategory", b =>
                {
                    b.HasOne("ShopApp.entity.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopApp.entity.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShopApp.entity.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("ShopApp.entity.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
