﻿// <auto-generated />
using System;
using Assingment_EFCore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assingment_EFCore.Infrastructure.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20240513165244_addnewProejct")]
    partial class addnewProejct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9f6bc4b5-2c54-4289-a1b0-93fbbd5236e0"),
                            Name = "Software Development"
                        },
                        new
                        {
                            Id = new Guid("f1ff5038-dccf-4ae3-9526-304b76e03553"),
                            Name = "Finance"
                        },
                        new
                        {
                            Id = new Guid("33ab29e9-d256-4b4d-b233-6ce22c3625e1"),
                            Name = "Accountant"
                        },
                        new
                        {
                            Id = new Guid("f614c858-1bcb-4bd3-beed-956560d4dfcd"),
                            Name = "HR"
                        },
                        new
                        {
                            Id = new Guid("e8952de1-f579-486a-99d5-a8218d8374e8"),
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = new Guid("55a0dd42-ea2f-4454-8a31-0e0fe6439fd0"),
                            Name = "Sales"
                        },
                        new
                        {
                            Id = new Guid("07edf3e4-3ccc-44c9-9923-9e51a121efe0"),
                            Name = "Customer Service"
                        });
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c058439-6cb1-4e61-bfb8-0191095b5e93"),
                            DepartmentId = new Guid("9f6bc4b5-2c54-4289-a1b0-93fbbd5236e0"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van A"
                        },
                        new
                        {
                            Id = new Guid("14fee08b-ab6e-4759-929a-0b147c8e19ff"),
                            DepartmentId = new Guid("f1ff5038-dccf-4ae3-9526-304b76e03553"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van B"
                        },
                        new
                        {
                            Id = new Guid("ddc70bce-98e9-4152-a92d-117ddd8997aa"),
                            DepartmentId = new Guid("9f6bc4b5-2c54-4289-a1b0-93fbbd5236e0"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van C"
                        },
                        new
                        {
                            Id = new Guid("f76fafce-2021-40f2-b163-368d9fa7c600"),
                            DepartmentId = new Guid("f614c858-1bcb-4bd3-beed-956560d4dfcd"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van D"
                        },
                        new
                        {
                            Id = new Guid("4ccdb5a9-ade2-4797-97cc-fa551ff2b91e"),
                            DepartmentId = new Guid("e8952de1-f579-486a-99d5-a8218d8374e8"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van E"
                        },
                        new
                        {
                            Id = new Guid("1ed28244-29c0-4881-9964-b0dc5237a310"),
                            DepartmentId = new Guid("55a0dd42-ea2f-4454-8a31-0e0fe6439fd0"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2016, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van F"
                        },
                        new
                        {
                            Id = new Guid("cb92e359-c100-4f27-85ae-68c32b5cab34"),
                            DepartmentId = new Guid("07edf3e4-3ccc-44c9-9923-9e51a121efe0"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van G"
                        },
                        new
                        {
                            Id = new Guid("95e73d54-81f8-47f7-830c-da1e42484b4d"),
                            DepartmentId = new Guid("9f6bc4b5-2c54-4289-a1b0-93fbbd5236e0"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van H"
                        },
                        new
                        {
                            Id = new Guid("87d5fac3-2cd1-4c83-9bf2-fc65c00de0ee"),
                            DepartmentId = new Guid("f1ff5038-dccf-4ae3-9526-304b76e03553"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van I"
                        },
                        new
                        {
                            Id = new Guid("5eaf9267-2f42-4bb7-9dde-9b3674da71ba"),
                            DepartmentId = new Guid("f614c858-1bcb-4bd3-beed-956560d4dfcd"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van K"
                        });
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5c735561-7a2c-47e0-85b6-e1dad02cb350"),
                            Name = "Project A"
                        },
                        new
                        {
                            Id = new Guid("518ae6c2-506f-4f98-9841-52ad994a1ad2"),
                            Name = "Project B"
                        },
                        new
                        {
                            Id = new Guid("aa3b8480-0349-427a-99f7-3c345ad8f3fa"),
                            Name = "Project C"
                        },
                        new
                        {
                            Id = new Guid("0bb86571-364b-4d8e-b59d-ba4e4dd55b8b"),
                            Name = "Project D"
                        },
                        new
                        {
                            Id = new Guid("4fdf3b0f-aaab-4655-b55b-9e2e09d8822e"),
                            Name = "Project E"
                        });
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.ProjectEmployee", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Enable")
                        .HasColumnType("bit");

                    b.HasKey("ProjectId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("ProjectEmployees");
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.Salary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("SalaryAmount")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.Employee", b =>
                {
                    b.HasOne("Assingment_EFCore.Domain.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.ProjectEmployee", b =>
                {
                    b.HasOne("Assingment_EFCore.Domain.Entities.Employee", "Employee")
                        .WithMany("ProjectEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assingment_EFCore.Domain.Entities.Project", "Project")
                        .WithMany("ProjectEmployees")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.Salary", b =>
                {
                    b.HasOne("Assingment_EFCore.Domain.Entities.Employee", "Employee")
                        .WithOne("Salary")
                        .HasForeignKey("Assingment_EFCore.Domain.Entities.Salary", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.Employee", b =>
                {
                    b.Navigation("ProjectEmployees");

                    b.Navigation("Salary")
                        .IsRequired();
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.Project", b =>
                {
                    b.Navigation("ProjectEmployees");
                });
#pragma warning restore 612, 618
        }
    }
}
