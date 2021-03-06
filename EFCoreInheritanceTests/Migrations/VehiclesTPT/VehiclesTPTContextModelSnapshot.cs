// <auto-generated />
using EFCoreInheritanceTests.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreInheritanceTests.Migrations.VehiclesTPT
{
    [DbContext(typeof(VehiclesTPTContext))]
    partial class VehiclesTPTContextModelSnapshot : ModelSnapshot
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

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles", (string)null);
                });

            modelBuilder.Entity("EFCoreInheritanceTests.Models.Car", b =>
                {
                    b.HasBaseType("EFCoreInheritanceTests.Models.Vehicle");

                    b.Property<int>("TrunkSizeInCm3")
                        .HasColumnType("int");

                    b.ToTable("Cars", (string)null);
                });

            modelBuilder.Entity("EFCoreInheritanceTests.Models.Motorbike", b =>
                {
                    b.HasBaseType("EFCoreInheritanceTests.Models.Vehicle");

                    b.Property<int>("RacingClass")
                        .HasColumnType("int");

                    b.ToTable("Motorbikes", (string)null);
                });

            modelBuilder.Entity("EFCoreInheritanceTests.Models.Car", b =>
                {
                    b.HasOne("EFCoreInheritanceTests.Models.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("EFCoreInheritanceTests.Models.Car", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreInheritanceTests.Models.Motorbike", b =>
                {
                    b.HasOne("EFCoreInheritanceTests.Models.Vehicle", null)
                        .WithOne()
                        .HasForeignKey("EFCoreInheritanceTests.Models.Motorbike", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
