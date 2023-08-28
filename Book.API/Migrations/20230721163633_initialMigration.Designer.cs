﻿// <auto-generated />
using System;
using Book.Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Book.API.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230721163633_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.6.23329.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Book.Data.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Books", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("6f07f310-89e7-4a87-8529-65236b0a22c9"),
                            CategoryType = 6,
                            CreatedDate = new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1042),
                            IsDeleted = false,
                            Name = "Cemile",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a4c4892b-145a-46b2-bfca-e78853d40cba"),
                            CategoryType = 6,
                            CreatedDate = new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1057),
                            IsDeleted = false,
                            Name = "Toprak Ana",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("51044623-e18a-41df-a495-19cede61e2aa"),
                            CategoryType = 5,
                            CreatedDate = new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1059),
                            IsDeleted = false,
                            Name = "Puslu Kıtalar Atlası",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("035e6c0e-75b8-45dc-a348-c9952a7c2882"),
                            CategoryType = 2,
                            CreatedDate = new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1061),
                            IsDeleted = false,
                            Name = "Tahıla Karsı",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Book.Data.Entities.Checkouts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Checkouts", (string)null);
                });

            modelBuilder.Entity("Book.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SignUpDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("10689c18-0bd0-4ac5-b693-4f460d6c1d3e"),
                            CreatedDate = new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1223),
                            Name = "Admin",
                            SignUpDate = new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1223),
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 0
                        },
                        new
                        {
                            Id = new Guid("2617c53c-d79f-4321-a294-c1582ab6f2de"),
                            CreatedDate = new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1226),
                            Name = "umutulupinar",
                            SignUpDate = new DateTime(2023, 7, 21, 19, 36, 33, 473, DateTimeKind.Local).AddTicks(1227),
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 1
                        });
                });

            modelBuilder.Entity("Book.Data.Entities.Checkouts", b =>
                {
                    b.HasOne("Book.Data.Entities.Book", "Book")
                        .WithMany("Checkouts")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Book.Data.Entities.User", "User")
                        .WithMany("Checkouts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Book.Data.Entities.Book", b =>
                {
                    b.Navigation("Checkouts");
                });

            modelBuilder.Entity("Book.Data.Entities.User", b =>
                {
                    b.Navigation("Checkouts");
                });
#pragma warning restore 612, 618
        }
    }
}