﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wsei_asp_net_lab.Models;

#nullable disable

namespace lab5.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221117140616_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("lab_5.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 11, 17, 15, 6, 16, 759, DateTimeKind.Local).AddTicks(5147),
                            ReleaseDate = new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "ASP.NET 6.0.0"
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2022, 11, 17, 15, 6, 16, 759, DateTimeKind.Local).AddTicks(5175),
                            ReleaseDate = new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "C# 10.0"
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2022, 11, 17, 15, 6, 16, 759, DateTimeKind.Local).AddTicks(5179),
                            ReleaseDate = new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Java 19"
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2022, 11, 17, 15, 6, 16, 759, DateTimeKind.Local).AddTicks(5183),
                            ReleaseDate = new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "JavaScript"
                        },
                        new
                        {
                            Id = 5,
                            Created = new DateTime(2022, 11, 17, 15, 6, 16, 759, DateTimeKind.Local).AddTicks(5187),
                            ReleaseDate = new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Node.js"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
