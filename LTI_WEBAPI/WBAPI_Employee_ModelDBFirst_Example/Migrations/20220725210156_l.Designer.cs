﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WBAPI_Employee_ModelDBFirst_Example.Models;

namespace WBAPI_Employee_ModelDBFirst_Example.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220725210156_l")]
    partial class l
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WBAPI_Employee_ModelDBFirst_Example.Models.Category", b =>
                {
                    b.Property<int>("catid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Catname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("catid");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WBAPI_Employee_ModelDBFirst_Example.Models.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WBAPI_Employee_ModelDBFirst_Example.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Productname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("categorycatid")
                        .HasColumnType("int");

                    b.Property<int>("catid")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("categorycatid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WBAPI_Employee_ModelDBFirst_Example.Models.ProductCatViewModel", b =>
                {
                    b.Property<int>("sno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Catid")
                        .HasColumnType("int");

                    b.Property<int>("Productid")
                        .HasColumnType("int");

                    b.Property<string>("catName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("productname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sno");

                    b.ToTable("ProductsCatwise");
                });

            modelBuilder.Entity("WBAPI_Employee_ModelDBFirst_Example.Models.Product", b =>
                {
                    b.HasOne("WBAPI_Employee_ModelDBFirst_Example.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categorycatid");
                });
#pragma warning restore 612, 618
        }
    }
}
