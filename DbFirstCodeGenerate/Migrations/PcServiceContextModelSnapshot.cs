﻿// <auto-generated />
using System;
using DbFirstCodeGenerate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DbFirstCodeGenerate.Migrations
{
    [DbContext(typeof(PcServiceContext))]
    partial class PcServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DbFirstCodeGenerate.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DbFirstCodeGenerate.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ServiceID")
                        .HasColumnType("int");

                    b.Property<int>("ServiceRecordServiceID")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InvoiceID");

                    b.HasIndex("ServiceRecordServiceID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DbFirstCodeGenerate.Models.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonelID"));

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PersonelLastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PersonelName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Position")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("PersonelID");

                    b.ToTable("Personel");
                });

            modelBuilder.Entity("DbFirstCodeGenerate.Models.ServiceRecord", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceID"));

                    b.Property<DateTime>("AcceptanceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("CostumerID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("DefectDescription")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("DeviceType")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("EstimatedCompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Serialnumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("ServiceStatusStatusID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("StatusID")
                        .HasColumnType("int");

                    b.HasKey("ServiceID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ServiceStatusStatusID");

                    b.ToTable("ServiceRecords");
                });

            modelBuilder.Entity("DbFirstCodeGenerate.Models.ServiceStatus", b =>
                {
                    b.Property<string>("StatusID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("StatusID");

                    b.ToTable("ServiceStatus");
                });

            modelBuilder.Entity("DbFirstCodeGenerate.Models.SparePart", b =>
                {
                    b.Property<int>("SpareID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpareID"));

                    b.Property<short?>("AmountOfStock")
                        .HasColumnType("smallint");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SpareBrand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SpareModel")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SpareName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SpareID");

                    b.ToTable("SpareParts");
                });

            modelBuilder.Entity("DbFirstCodeGenerate.Models.WorkAssignment", b =>
                {
                    b.Property<int>("WorkAssigmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkAssigmentID"));

                    b.Property<int?>("PersonelID")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceID")
                        .HasColumnType("int");

                    b.Property<int>("ServiceRecordServiceID")
                        .HasColumnType("int");

                    b.HasKey("WorkAssigmentID");

                    b.HasIndex("PersonelID");

                    b.HasIndex("ServiceRecordServiceID");

                    b.ToTable("WorkAssignments");
                });

            modelBuilder.Entity("DbFirstCodeGenerate.Models.Invoice", b =>
                {
                    b.HasOne("DbFirstCodeGenerate.Models.ServiceRecord", "ServiceRecord")
                        .WithMany()
                        .HasForeignKey("ServiceRecordServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceRecord");
                });

            modelBuilder.Entity("DbFirstCodeGenerate.Models.ServiceRecord", b =>
                {
                    b.HasOne("DbFirstCodeGenerate.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbFirstCodeGenerate.Models.ServiceStatus", "ServiceStatus")
                        .WithMany()
                        .HasForeignKey("ServiceStatusStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("ServiceStatus");
                });

            modelBuilder.Entity("DbFirstCodeGenerate.Models.WorkAssignment", b =>
                {
                    b.HasOne("DbFirstCodeGenerate.Models.Personel", "Personel")
                        .WithMany()
                        .HasForeignKey("PersonelID");

                    b.HasOne("DbFirstCodeGenerate.Models.ServiceRecord", "ServiceRecord")
                        .WithMany()
                        .HasForeignKey("ServiceRecordServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");

                    b.Navigation("ServiceRecord");
                });
#pragma warning restore 612, 618
        }
    }
}
