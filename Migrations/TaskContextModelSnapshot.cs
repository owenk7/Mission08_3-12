﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission08_3_12.Models;

namespace Mission08_3_12.Migrations
{
    [DbContext(typeof(TaskContext))]
    partial class TaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission08_3_12.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Mission08_3_12.Models.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            TaskId = 1,
                            CategoryId = 2,
                            Completed = false,
                            DueDate = new DateTime(2023, 2, 22, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = 1,
                            TaskName = "Homework for 404"
                        },
                        new
                        {
                            TaskId = 2,
                            CategoryId = 2,
                            Completed = false,
                            DueDate = new DateTime(2023, 2, 23, 23, 59, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = 1,
                            TaskName = "Authentication Lab"
                        },
                        new
                        {
                            TaskId = 3,
                            CategoryId = 1,
                            Completed = false,
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Quadrant = 4,
                            TaskName = "Watch TV"
                        });
                });

            modelBuilder.Entity("Mission08_3_12.Models.Task", b =>
                {
                    b.HasOne("Mission08_3_12.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
