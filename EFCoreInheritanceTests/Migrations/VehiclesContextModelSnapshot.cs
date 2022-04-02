﻿// <auto-generated />
using EFCoreInheritanceTests.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreInheritanceTests.Migrations
{
    [DbContext(typeof(VehiclesContext))]
    partial class VehiclesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCoreInheritanceTests.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Vehicle");
                });

            modelBuilder.Entity("EFCoreInheritanceTests.Models.Car", b =>
                {
                    b.HasBaseType("EFCoreInheritanceTests.Models.Vehicle");

                    b.Property<int>("TrunkSizeInCm3")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Car");
                });

            modelBuilder.Entity("EFCoreInheritanceTests.Models.Motorbike", b =>
                {
                    b.HasBaseType("EFCoreInheritanceTests.Models.Vehicle");

                    b.Property<int>("RacingClass")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Motorbike");
                });
#pragma warning restore 612, 618
        }
    }
}
