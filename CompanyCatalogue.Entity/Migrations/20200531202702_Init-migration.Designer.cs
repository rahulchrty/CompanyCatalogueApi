﻿// <auto-generated />
using CompanyCatalogue.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompanyCatalogue.Entity.Migrations
{
    [DbContext(typeof(CatalogueContext))]
    [Migration("20200531202702_Init-migration")]
    partial class Initmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompanyCatalogue.Models.Catalogue", b =>
                {
                    b.Property<string>("CatalogueId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatalogueId");

                    b.ToTable("Catalogues");
                });

            modelBuilder.Entity("CompanyCatalogue.Models.CompanyDetail", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatalogueId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfEmployees")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubSector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalRevenues")
                        .HasColumnType("float");

                    b.Property<string>("WebSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.HasIndex("CatalogueId");

                    b.ToTable("CompanyDetails");
                });

            modelBuilder.Entity("CompanyCatalogue.Models.CompanyDetail", b =>
                {
                    b.HasOne("CompanyCatalogue.Models.Catalogue", "Catalogue")
                        .WithMany("CompanyDetails")
                        .HasForeignKey("CatalogueId")
                        .HasConstraintName("FK_Catalogue_CatalogueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
