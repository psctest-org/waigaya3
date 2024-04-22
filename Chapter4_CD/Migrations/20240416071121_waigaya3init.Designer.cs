﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Waigaya3.Data;

#nullable disable

namespace Waigaya3.Migrations
{
    [DbContext(typeof(WaigayaDbContext))]
    [Migration("20240416071121_waigaya3init")]
    partial class waigaya3init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Waigaya3.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 4, 16, 16, 11, 20, 932, DateTimeKind.Local).AddTicks(2844),
                            Title = "回復アイテム"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 16, 16, 11, 20, 932, DateTimeKind.Local).AddTicks(2846),
                            Title = "武器"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 4, 16, 16, 11, 20, 932, DateTimeKind.Local).AddTicks(2848),
                            Title = "防具"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 4, 16, 16, 11, 20, 932, DateTimeKind.Local).AddTicks(2849),
                            Title = "家電"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 4, 16, 16, 11, 20, 932, DateTimeKind.Local).AddTicks(2850),
                            Title = "生活用品"
                        });
                });

            modelBuilder.Entity("Waigaya3.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("delete_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2024, 4, 16, 16, 11, 20, 932, DateTimeKind.Local).AddTicks(2975),
                            Description = "エクスカリバーには、普通の剣には無い特別な力が備わって\r\nいたと考えられています。敵の攻撃を跳ね返す魔力や、所持\r\n者に無敵の力を与える等の能力が伝承されています。",
                            Name = "エクスカリバー",
                            Price = 54000m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2024, 4, 16, 16, 11, 20, 932, DateTimeKind.Local).AddTicks(2977),
                            Description = "ユニクロで売ってます",
                            Name = "ヒートテック",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2024, 4, 16, 16, 11, 20, 932, DateTimeKind.Local).AddTicks(2979),
                            Description = "ダイソンではない",
                            Name = "掃除機",
                            Price = 30000m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 5,
                            CreatedAt = new DateTime(2024, 4, 16, 16, 11, 20, 932, DateTimeKind.Local).AddTicks(2981),
                            Description = "たんぱく質を英語でいうとプロテイン",
                            Name = "プロテイン",
                            Price = 4000m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            CreatedAt = new DateTime(2024, 4, 16, 16, 11, 20, 932, DateTimeKind.Local).AddTicks(2983),
                            Description = "ただの水です",
                            Name = "500mlの水",
                            Price = 100m
                        });
                });

            modelBuilder.Entity("Waigaya3.Models.Product", b =>
                {
                    b.HasOne("Waigaya3.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Waigaya3.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
