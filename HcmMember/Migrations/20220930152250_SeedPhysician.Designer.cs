﻿// <auto-generated />
using System;
using HcmMember.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HcmMember.Migrations
{
    [DbContext(typeof(ToDoContext))]
    [Migration("20220930152250_SeedPhysician")]
    partial class SeedPhysician
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HcmMember.Modals.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("LastModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhysicianId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberId");

                    b.HasIndex("PhysicianId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("HcmMember.Modals.Physician", b =>
                {
                    b.Property<int>("PhysicianId")
                        .HasColumnType("int");

                    b.Property<string>("PhysicianName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhysicianState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhysicianId");

                    b.ToTable("Physicians");

                    b.HasData(
                        new
                        {
                            PhysicianId = 1,
                            PhysicianName = "John",
                            PhysicianState = "UT"
                        },
                        new
                        {
                            PhysicianId = 2,
                            PhysicianName = "Hari",
                            PhysicianState = "UA"
                        },
                        new
                        {
                            PhysicianId = 3,
                            PhysicianName = "Mittal",
                            PhysicianState = "TX"
                        },
                        new
                        {
                            PhysicianId = 4,
                            PhysicianName = "Patrick",
                            PhysicianState = "OH"
                        },
                        new
                        {
                            PhysicianId = 5,
                            PhysicianName = "Mark",
                            PhysicianState = "CA"
                        },
                        new
                        {
                            PhysicianId = 6,
                            PhysicianName = "Jessica",
                            PhysicianState = "NY"
                        },
                        new
                        {
                            PhysicianId = 7,
                            PhysicianName = "Mary",
                            PhysicianState = "IL"
                        },
                        new
                        {
                            PhysicianId = 8,
                            PhysicianName = "Stacy",
                            PhysicianState = "FL"
                        });
                });

            modelBuilder.Entity("HcmMember.Modals.Member", b =>
                {
                    b.HasOne("HcmMember.Modals.Physician", "Physician")
                        .WithMany("Members")
                        .HasForeignKey("PhysicianId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Physician");
                });

            modelBuilder.Entity("HcmMember.Modals.Physician", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
