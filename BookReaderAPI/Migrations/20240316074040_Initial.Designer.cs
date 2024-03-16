﻿// <auto-generated />
using BookReaderDataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookReaderAPI.Migrations
{
    [DbContext(typeof(BookReaderContext))]
    [Migration("20240316074040_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("BookReaderDataAccess.Models.BookContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("BookContents");
                });

            modelBuilder.Entity("BookReaderDataAccess.Models.BookDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookContentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookPictureId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Pages")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BookContentId");

                    b.HasIndex("BookPictureId");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("BookReaderDataAccess.Models.BookPicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("BookPictures");
                });

            modelBuilder.Entity("BookReaderDataAccess.Models.BookDetails", b =>
                {
                    b.HasOne("BookReaderDataAccess.Models.BookContent", "BookContent")
                        .WithMany()
                        .HasForeignKey("BookContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookReaderDataAccess.Models.BookPicture", "BookPicture")
                        .WithMany()
                        .HasForeignKey("BookPictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookContent");

                    b.Navigation("BookPicture");
                });
#pragma warning restore 612, 618
        }
    }
}