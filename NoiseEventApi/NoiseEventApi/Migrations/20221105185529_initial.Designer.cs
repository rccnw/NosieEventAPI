﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoiseEventApi;

#nullable disable

namespace NoiseEventApi.Migrations
{
    [DbContext(typeof(NoiseEventDbContext))]
    [Migration("20221105185529_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0-rc.2.22472.11");

            modelBuilder.Entity("NoiseEventApi.NoiseEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UtcTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("NoiseEvents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Data = "event 1",
                            Latitude = "",
                            Longitude = "",
                            Type = "",
                            UtcTime = "11/5/2022 6:55:29 PM"
                        },
                        new
                        {
                            Id = 2,
                            Data = "event 2",
                            Latitude = "",
                            Longitude = "",
                            Type = "",
                            UtcTime = "11/5/2022 6:55:29 PM"
                        },
                        new
                        {
                            Id = 3,
                            Data = "event 3",
                            Latitude = "",
                            Longitude = "",
                            Type = "",
                            UtcTime = "11/5/2022 6:55:29 PM"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
