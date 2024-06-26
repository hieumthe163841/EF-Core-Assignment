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
    [Migration("20240514163438_seedDataEnable")]
    partial class seedDataEnable
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
                            Id = new Guid("eb47d83e-8f33-49ba-a025-dec701ab75ee"),
                            Name = "Software Development"
                        },
                        new
                        {
                            Id = new Guid("077caa19-4752-4e32-a050-89b9c8d00672"),
                            Name = "Finance"
                        },
                        new
                        {
                            Id = new Guid("704a08d9-3b65-4d90-b55e-9c9bb3c09c39"),
                            Name = "Accountant"
                        },
                        new
                        {
                            Id = new Guid("44c91649-c8b6-4bbe-8d70-a9b3e6068703"),
                            Name = "HR"
                        },
                        new
                        {
                            Id = new Guid("204727bc-d435-45ad-bcac-05a752e19b42"),
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = new Guid("88f10de2-ec3c-4c8e-bce6-4c42fbbbe2e1"),
                            Name = "Sales"
                        },
                        new
                        {
                            Id = new Guid("14d224a2-b38c-40c8-9043-6b9a0b970d4d"),
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
                            Id = new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"),
                            DepartmentId = new Guid("eb47d83e-8f33-49ba-a025-dec701ab75ee"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van A"
                        },
                        new
                        {
                            Id = new Guid("48b448b3-299a-485e-8c70-48967185ac04"),
                            DepartmentId = new Guid("077caa19-4752-4e32-a050-89b9c8d00672"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van B"
                        },
                        new
                        {
                            Id = new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"),
                            DepartmentId = new Guid("eb47d83e-8f33-49ba-a025-dec701ab75ee"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2019, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van C"
                        },
                        new
                        {
                            Id = new Guid("72814f03-70cb-4d9a-8541-1f713fc6762e"),
                            DepartmentId = new Guid("44c91649-c8b6-4bbe-8d70-a9b3e6068703"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2018, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van D"
                        },
                        new
                        {
                            Id = new Guid("73def274-5e7c-4476-881c-46c7bb428938"),
                            DepartmentId = new Guid("204727bc-d435-45ad-bcac-05a752e19b42"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van E"
                        },
                        new
                        {
                            Id = new Guid("7c55e16a-6c45-4a95-948a-2c52b3f3c7ad"),
                            DepartmentId = new Guid("88f10de2-ec3c-4c8e-bce6-4c42fbbbe2e1"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2016, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van F"
                        },
                        new
                        {
                            Id = new Guid("2f27c155-d28d-4a8c-9edd-dfd928c945e3"),
                            DepartmentId = new Guid("14d224a2-b38c-40c8-9043-6b9a0b970d4d"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van G"
                        },
                        new
                        {
                            Id = new Guid("32ab0fa0-0759-44de-b7a3-186942f4484f"),
                            DepartmentId = new Guid("eb47d83e-8f33-49ba-a025-dec701ab75ee"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van H"
                        },
                        new
                        {
                            Id = new Guid("6a18e901-c6e0-4d8d-90e6-2b1d4e3d5ef5"),
                            DepartmentId = new Guid("077caa19-4752-4e32-a050-89b9c8d00672"),
                            IsDeleted = false,
                            JoinedDate = new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nguyen Van I"
                        },
                        new
                        {
                            Id = new Guid("94b9dd0b-0b4a-4a80-9b0c-f2d04824c70d"),
                            DepartmentId = new Guid("44c91649-c8b6-4bbe-8d70-a9b3e6068703"),
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
                            Id = new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"),
                            Name = "Project A"
                        },
                        new
                        {
                            Id = new Guid("bc5e777e-265c-4964-aa59-708076744a3a"),
                            Name = "Project B"
                        },
                        new
                        {
                            Id = new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85"),
                            Name = "Project C"
                        },
                        new
                        {
                            Id = new Guid("57839bbc-e60f-4e33-a4da-c336a86799ae"),
                            Name = "Project D"
                        },
                        new
                        {
                            Id = new Guid("3483cd91-651e-4a40-8505-1d24d733764d"),
                            Name = "Project E"
                        },
                        new
                        {
                            Id = new Guid("1fa11c89-5d1d-448c-961c-19455e1841af"),
                            Name = "Project F"
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

                    b.HasData(
                        new
                        {
                            ProjectId = new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"),
                            EmployeeId = new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"),
                            Enable = true
                        },
                        new
                        {
                            ProjectId = new Guid("bc5e777e-265c-4964-aa59-708076744a3a"),
                            EmployeeId = new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"),
                            Enable = true
                        },
                        new
                        {
                            ProjectId = new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85"),
                            EmployeeId = new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"),
                            Enable = true
                        },
                        new
                        {
                            ProjectId = new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"),
                            EmployeeId = new Guid("48b448b3-299a-485e-8c70-48967185ac04"),
                            Enable = true
                        },
                        new
                        {
                            ProjectId = new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85"),
                            EmployeeId = new Guid("48b448b3-299a-485e-8c70-48967185ac04"),
                            Enable = true
                        },
                        new
                        {
                            ProjectId = new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"),
                            EmployeeId = new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"),
                            Enable = true
                        },
                        new
                        {
                            ProjectId = new Guid("bc5e777e-265c-4964-aa59-708076744a3a"),
                            EmployeeId = new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"),
                            Enable = true
                        },
                        new
                        {
                            ProjectId = new Guid("2cb4b1e6-ea74-40be-99e7-71b53124ba85"),
                            EmployeeId = new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"),
                            Enable = true
                        },
                        new
                        {
                            ProjectId = new Guid("e20bea29-d1c4-4688-a69a-a634f6675a54"),
                            EmployeeId = new Guid("72814f03-70cb-4d9a-8541-1f713fc6762e"),
                            Enable = true
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("a9f2c783-795d-4e4f-92c8-4b830f721d6f"),
                            EmployeeId = new Guid("e00eb695-16af-41e3-8d2e-0258b1c2e797"),
                            SalaryAmount = 1000m
                        },
                        new
                        {
                            Id = new Guid("0cf5af08-2b13-42cd-b340-0617861779ed"),
                            EmployeeId = new Guid("48b448b3-299a-485e-8c70-48967185ac04"),
                            SalaryAmount = 2000m
                        },
                        new
                        {
                            Id = new Guid("62947484-15b8-4c31-863f-2f10161e9c8a"),
                            EmployeeId = new Guid("bf57cf1b-2026-436d-894e-dd6a711756fb"),
                            SalaryAmount = 3000m
                        },
                        new
                        {
                            Id = new Guid("5a569bfd-a7fb-498c-8d82-b56b653478a5"),
                            EmployeeId = new Guid("73def274-5e7c-4476-881c-46c7bb428938"),
                            SalaryAmount = 5000m
                        },
                        new
                        {
                            Id = new Guid("55464761-c00c-4da4-9eee-63175586670f"),
                            EmployeeId = new Guid("7c55e16a-6c45-4a95-948a-2c52b3f3c7ad"),
                            SalaryAmount = 6000m
                        },
                        new
                        {
                            Id = new Guid("33463341-1720-43d1-9ca7-237653e7eec0"),
                            EmployeeId = new Guid("2f27c155-d28d-4a8c-9edd-dfd928c945e3"),
                            SalaryAmount = 7000m
                        },
                        new
                        {
                            Id = new Guid("addee1fb-90bd-48d6-bc82-b1ba3f658102"),
                            EmployeeId = new Guid("32ab0fa0-0759-44de-b7a3-186942f4484f"),
                            SalaryAmount = 8000m
                        },
                        new
                        {
                            Id = new Guid("26cda848-e8d1-40a4-b5ee-544e16f68443"),
                            EmployeeId = new Guid("6a18e901-c6e0-4d8d-90e6-2b1d4e3d5ef5"),
                            SalaryAmount = 9000m
                        },
                        new
                        {
                            Id = new Guid("8c42be0d-e8b1-4f8a-a8d8-19fc52cb9fce"),
                            EmployeeId = new Guid("94b9dd0b-0b4a-4a80-9b0c-f2d04824c70d"),
                            SalaryAmount = 10000m
                        });
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

                    b.Navigation("Salary");
                });

            modelBuilder.Entity("Assingment_EFCore.Domain.Entities.Project", b =>
                {
                    b.Navigation("ProjectEmployees");
                });
#pragma warning restore 612, 618
        }
    }
}
