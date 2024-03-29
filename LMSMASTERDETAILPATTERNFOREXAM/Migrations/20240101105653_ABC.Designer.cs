﻿// <auto-generated />
using System;
using LMSMASTERDETAILPATTERNFOREXAM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LMSMASTERDETAILPATTERNFOREXAM.Migrations
{
    [DbContext(typeof(LibraryDB))]
    [Migration("20240101105653_ABC")]
    partial class ABC
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LMSMASTERDETAILPATTERNFOREXAM.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BookBorrowingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BookReturningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<decimal>("RentPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("GenreId");

                    b.HasIndex("StudentId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LMSMASTERDETAILPATTERNFOREXAM.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreId"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("LMSMASTERDETAILPATTERNFOREXAM.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LMSMASTERDETAILPATTERNFOREXAM.Models.Book", b =>
                {
                    b.HasOne("LMSMASTERDETAILPATTERNFOREXAM.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId");

                    b.HasOne("LMSMASTERDETAILPATTERNFOREXAM.Models.Student", "Student")
                        .WithMany("Books")
                        .HasForeignKey("StudentId");

                    b.Navigation("Genre");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LMSMASTERDETAILPATTERNFOREXAM.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LMSMASTERDETAILPATTERNFOREXAM.Models.Student", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
