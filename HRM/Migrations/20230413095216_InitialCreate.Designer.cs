﻿// <auto-generated />
using HRM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRM.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230413095216_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HRM.Models.Department", b =>
                {
                    b.Property<string>("department_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("department_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("department_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HRM.Models.Employee", b =>
                {
                    b.Property<string>("employee_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("base_salary")
                        .HasColumnType("float");

                    b.Property<double>("coefficients_salary")
                        .HasColumnType("float");

                    b.Property<string>("department_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employee_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("employee_id");

                    b.ToTable("Assets");
                });
#pragma warning restore 612, 618
        }
    }
}
