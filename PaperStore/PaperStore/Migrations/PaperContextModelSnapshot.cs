﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaperStore;

namespace PaperStore.Migrations
{
    [DbContext(typeof(PaperContext))]
    partial class PaperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PaperStore.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Nip")
                        .HasMaxLength(10);

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<int?>("RelationCodeId");

                    b.HasKey("Id");

                    b.HasIndex("RelationCodeId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("PaperStore.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("PaperStore.Models.InvoiceSupplies", b =>
                {
                    b.Property<int>("InvoiceId");

                    b.Property<int>("SuppliesId");

                    b.HasKey("InvoiceId", "SuppliesId");

                    b.HasIndex("SuppliesId");

                    b.ToTable("InvoiceSupplies");
                });

            modelBuilder.Entity("PaperStore.Models.RelationCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("RelationCode");
                });

            modelBuilder.Entity("PaperStore.Models.Supplies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.Property<decimal>("NetPrice");

                    b.Property<decimal>("PurchasePrice");

                    b.Property<int>("Qty");

                    b.HasKey("Id");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("PaperStore.Models.Company", b =>
                {
                    b.HasOne("PaperStore.Models.RelationCode", "RelationCode")
                        .WithMany()
                        .HasForeignKey("RelationCodeId");
                });

            modelBuilder.Entity("PaperStore.Models.Invoice", b =>
                {
                    b.HasOne("PaperStore.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("PaperStore.Models.InvoiceSupplies", b =>
                {
                    b.HasOne("PaperStore.Models.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PaperStore.Models.Supplies", "Supplies")
                        .WithMany()
                        .HasForeignKey("SuppliesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
