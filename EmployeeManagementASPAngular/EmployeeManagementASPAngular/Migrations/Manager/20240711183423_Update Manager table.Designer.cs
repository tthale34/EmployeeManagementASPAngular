﻿// <auto-generated />
using EmployeeManagementASPAngular.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagementASPAngular.Migrations.Manager
{
    [DbContext(typeof(ManagerContext))]
    [Migration("20240711183423_Update Manager table")]
    partial class UpdateManagertable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EmployeeManagementASPAngular.Model.Manager", b =>
                {
                    b.Property<int>("ManagerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ManagerManagerDepartment")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ManagerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ManagerSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ManagerId");

                    b.ToTable("Managers");
                });
#pragma warning restore 612, 618
        }
    }
}
