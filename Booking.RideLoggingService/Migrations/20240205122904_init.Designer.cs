﻿// <auto-generated />
using System;
using Booking.RideLoggingSerivce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Booking.RideLoggingService.Migrations
{
    [DbContext(typeof(RideLoggingServiceDbContext))]
    [Migration("20240205122904_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Booking.RideLoggingSerivce.Models.BookingHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CancelDateTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("canceldatetime");

                    b.Property<string>("CancelReason")
                        .HasColumnType("text")
                        .HasColumnName("cancelreason");

                    b.Property<string>("CancelledBy")
                        .HasColumnType("text")
                        .HasColumnName("cancelledby");

                    b.Property<DateTime?>("ConfirmedDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("confirmeddate");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("boolean")
                        .HasColumnName("iscancelled");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("isconfirmed");

                    b.Property<string>("Rider")
                        .HasColumnType("text")
                        .HasColumnName("rider");

                    b.HasKey("Id")
                        .HasName("pk_bookinghistories");

                    b.ToTable("bookinghistories", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
