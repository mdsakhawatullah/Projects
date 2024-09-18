﻿// <auto-generated />
using System;
using MasjidManagementSystem.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MasjidManagementSystem.Migrations
{
    [DbContext(typeof(MasjidDbContext))]
    [Migration("20240918131301_AddDonationTable")]
    partial class AddDonationTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MasjidManagementSystem.Models.Donation", b =>
                {
                    b.Property<string>("DonarName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("DonationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DonarName");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("MasjidManagementSystem.Models.Event", b =>
                {
                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventName");

                    b.ToTable("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
