﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sportpad.Data;

namespace Sportpad.Migrations
{
    [DbContext(typeof(SportpadContext))]
    [Migration("20221203162602_ApplicationUser")]
    partial class ApplicationUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sportpad.Models.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LocationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaximumNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SportId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("SportId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("Sportpad.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Sportpad.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<Guid>("User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("Sportpad.Models.Sport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Sport");
                });

            modelBuilder.Entity("Sportpad.Models.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("Sportpad.Models.Event", b =>
                {
                    b.HasOne("Sportpad.Models.Location", "Location")
                        .WithMany("Event")
                        .HasForeignKey("LocationId");

                    b.HasOne("Sportpad.Models.Sport", "Sport")
                        .WithMany("Events")
                        .HasForeignKey("SportId");

                    b.Navigation("Location");

                    b.Navigation("Sport");
                });

            modelBuilder.Entity("Sportpad.Models.Rating", b =>
                {
                    b.HasOne("Sportpad.Models.UserProfile", null)
                        .WithMany("Ratings")
                        .HasForeignKey("UserProfileId");
                });

            modelBuilder.Entity("Sportpad.Models.Sport", b =>
                {
                    b.HasOne("Sportpad.Models.UserProfile", null)
                        .WithMany("Sports")
                        .HasForeignKey("UserProfileId");
                });

            modelBuilder.Entity("Sportpad.Models.Location", b =>
                {
                    b.Navigation("Event");
                });

            modelBuilder.Entity("Sportpad.Models.Sport", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("Sportpad.Models.UserProfile", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("Sports");
                });
#pragma warning restore 612, 618
        }
    }
}
