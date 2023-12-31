﻿// <auto-generated />
using System;
using Book.Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Book.API.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("acde91c1-76af-4b97-91b1-59c7d034b493"),
                            CategoryType = 6,
                            CreatedDate = new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(4892),
                            IsDeleted = false,
                            Name = "Cemile",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("da6072a4-0154-4eed-9bc9-e0ca9212561a"),
                            CategoryType = 6,
                            CreatedDate = new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(4933),
                            IsDeleted = false,
                            Name = "Toprak Ana",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("dc0b55cb-51fd-4e08-86f2-0aeb4db6fd99"),
                            CategoryType = 5,
                            CreatedDate = new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(4935),
                            IsDeleted = false,
                            Name = "Puslu Kıtalar Atlası",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("fa9a551b-1190-48aa-8f60-610e744178f0"),
                            CategoryType = 2,
                            CreatedDate = new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(4936),
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

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SignUpDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7fb4546d-e885-4809-ab36-79bd2d9eb7c3"),
                            CreatedDate = new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(5057),
                            Name = "Admin",
                            Password = "1234",
                            SignUpDate = new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(5057),
                            Token = "",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserType = 0
                        },
                        new
                        {
                            Id = new Guid("b134ad06-e879-4fd0-a5c6-29b74a9ee412"),
                            CreatedDate = new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(5059),
                            Name = "umutulupinar",
                            Password = "1234",
                            SignUpDate = new DateTime(2023, 7, 24, 17, 13, 33, 492, DateTimeKind.Local).AddTicks(5060),
                            Token = "",
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
