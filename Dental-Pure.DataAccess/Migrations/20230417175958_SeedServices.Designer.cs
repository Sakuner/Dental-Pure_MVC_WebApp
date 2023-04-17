﻿// <auto-generated />
using System;
using Dental_Pure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dental_Pure.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230417175958_SeedServices")]
    partial class SeedServices
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dental_Pure.Entities.ReservationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignedDoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AssignedDoctorId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Dental_Pure.Entities.ServiceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dental examination",
                            Price = 0.0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dental surgery",
                            Price = 100.0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fluoridation of teeth",
                            Price = 90.0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Prosthodontic consultation",
                            Price = 0.0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Teeth sealing",
                            Price = 80.0
                        },
                        new
                        {
                            Id = 6,
                            Name = "Treatment of dental caries",
                            Price = 70.0
                        },
                        new
                        {
                            Id = 7,
                            Name = "Denture repair",
                            Price = 200.0
                        },
                        new
                        {
                            Id = 8,
                            Name = "Teeth restoration",
                            Price = 150.0
                        },
                        new
                        {
                            Id = 9,
                            Name = "Dentures",
                            Price = 750.0
                        },
                        new
                        {
                            Id = 10,
                            Name = "Tartar removal",
                            Price = 140.0
                        },
                        new
                        {
                            Id = 11,
                            Name = "Teeth removal",
                            Price = 100.0
                        },
                        new
                        {
                            Id = 12,
                            Name = "Composite filling",
                            Price = 80.0
                        },
                        new
                        {
                            Id = 13,
                            Name = "Gum excision",
                            Price = 100.0
                        });
                });

            modelBuilder.Entity("Dental_Pure.Entities.StaffModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StaffEmployee");
                });

            modelBuilder.Entity("Dental_Pure.Entities.ReservationModel", b =>
                {
                    b.HasOne("Dental_Pure.Entities.StaffModel", "AssignedDoctor")
                        .WithMany()
                        .HasForeignKey("AssignedDoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedDoctor");
                });
#pragma warning restore 612, 618
        }
    }
}
