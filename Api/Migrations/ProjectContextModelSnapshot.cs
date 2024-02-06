﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VolvoFinalProject.Api.Model.Models;

#nullable disable

namespace VolvoFinalProject.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Bill", b =>
                {
                    b.Property<int>("BillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillID"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("CustomerFK")
                        .HasColumnType("int");

                    b.Property<int>("ServiceFK")
                        .HasColumnType("int");

                    b.HasKey("BillID");

                    b.HasIndex("CustomerFK");

                    b.HasIndex("ServiceFK");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.CategoryService", b =>
                {
                    b.Property<int>("CategoryServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryServiceID"));

                    b.Property<int>("Category")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<int>("ExecutionTime")
                        .HasColumnType("int");

                    b.Property<int>("ServiceFK")
                        .HasColumnType("int");

                    b.HasKey("CategoryServiceID");

                    b.HasIndex("ServiceFK");

                    b.ToTable("CategoryServices");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Contacts", b =>
                {
                    b.Property<int>("ContactsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactsID"));

                    b.Property<int>("AddressNumber")
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelephoneType")
                        .HasColumnType("int");

                    b.HasKey("ContactsID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<int>("ContactFK")
                        .HasColumnType("int");

                    b.Property<int>("DealerFK")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerID");

                    b.HasIndex("ContactFK");

                    b.HasIndex("DealerFK");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Dealer", b =>
                {
                    b.Property<int>("DealerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DealerID"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<int>("ContactFK")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DealerID");

                    b.HasIndex("ContactFK");

                    b.ToTable("Dealers");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<double>("BaseSalary")
                        .HasColumnType("float");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<double>("Commission")
                        .HasColumnType("float");

                    b.Property<int>("ContactFK")
                        .HasColumnType("int");

                    b.Property<int>("DealerFK")
                        .HasColumnType("int");

                    b.Property<int>("Employees")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("ContactFK");

                    b.HasIndex("DealerFK");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Parts", b =>
                {
                    b.Property<int>("PartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PartID"));

                    b.Property<string>("Availabity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryServiceFK")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("PartID");

                    b.HasIndex("CategoryServiceFK");

                    b.ToTable("Part");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DealerFK")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeFK")
                        .HasColumnType("int");

                    b.Property<int>("Situation")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("ServiceID");

                    b.HasIndex("DealerFK");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleID"));

                    b.Property<int>("ChassisNumber")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CustomerFK")
                        .HasColumnType("int");

                    b.Property<double>("Kilometrage")
                        .HasColumnType("float");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SystemVersion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("VehicleID");

                    b.HasIndex("CustomerFK");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Bill", b =>
                {
                    b.HasOne("VolvoFinalProject.Api.Model.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("VolvoFinalProject.Api.Model.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.CategoryService", b =>
                {
                    b.HasOne("VolvoFinalProject.Api.Model.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Service");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Customer", b =>
                {
                    b.HasOne("VolvoFinalProject.Api.Model.Models.Contacts", "Contacts")
                        .WithMany()
                        .HasForeignKey("ContactFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("VolvoFinalProject.Api.Model.Models.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contacts");

                    b.Navigation("Dealer");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Dealer", b =>
                {
                    b.HasOne("VolvoFinalProject.Api.Model.Models.Contacts", "Contacts")
                        .WithMany()
                        .HasForeignKey("ContactFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Employee", b =>
                {
                    b.HasOne("VolvoFinalProject.Api.Model.Models.Contacts", "Contacts")
                        .WithMany()
                        .HasForeignKey("ContactFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("VolvoFinalProject.Api.Model.Models.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Contacts");

                    b.Navigation("Dealer");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Parts", b =>
                {
                    b.HasOne("VolvoFinalProject.Api.Model.Models.CategoryService", "CategoryService")
                        .WithMany()
                        .HasForeignKey("CategoryServiceFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CategoryService");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Service", b =>
                {
                    b.HasOne("VolvoFinalProject.Api.Model.Models.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Dealer");
                });

            modelBuilder.Entity("VolvoFinalProject.Api.Model.Models.Vehicle", b =>
                {
                    b.HasOne("VolvoFinalProject.Api.Model.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerFK")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
