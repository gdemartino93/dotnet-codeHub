﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using codeHub.DataAccess.Data;

#nullable disable

namespace codeHub.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230424094036_addImageProp")]
    partial class addImageProp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("codeHub.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Java World",
                            DisplayOrder = 1,
                            IsVisible = true,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 2,
                            Description = "C# World",
                            DisplayOrder = 1,
                            IsVisible = true,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 3,
                            Description = "CSS World",
                            DisplayOrder = 1,
                            IsVisible = true,
                            Name = "CSS"
                        });
                });

            modelBuilder.Entity("codeHub.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Learn the fundamentals of computer science with Python",
                            Level = "Intermediate",
                            Price = 50.0,
                            Text = "This course is designed to teach you the basics of computer science using Python. Topics include: algorithms, data structures, recursion, sorting, and searching. By the end of the course, you will have a strong foundation in computer science and be able to write basic programs in Python.",
                            Title = "Introduction to Computer Science with Python"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2022, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Learn how to build scalable and performant web applications with React",
                            LastUpdatedAt = new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Level = "Advanced",
                            Price = 100.0,
                            Text = "In this course, you will learn how to build modern web applications with React. Topics include: React components, state management with Redux, server-side rendering, and performance optimization. By the end of the course, you will be able to build scalable and performant web applications with React.",
                            Title = "Mastering React"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Learn how to build full-stack web applications with Node.js and MongoDB",
                            Level = "Intermediate",
                            Price = 75.0,
                            Text = "This course teaches you how to build full-stack web applications using Node.js and MongoDB. Topics include: RESTful APIs, authentication and authorization, database design, and deployment. By the end of the course, you will be able to build and deploy a full-stack web application with Node.js and MongoDB.",
                            Title = "Full-Stack Web Development with Node.js and MongoDB"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Learn how to use machine learning to analyze and visualize data",
                            LastUpdatedAt = new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Level = "Advanced",
                            Price = 150.0,
                            Text = "In this course, you will learn how to use machine learning techniques to analyze and visualize data. Topics include: data preprocessing, dimensionality reduction, clustering, classification, and regression. You will also learn how to use popular machine learning libraries such as scikit-learn and TensorFlow. By the end of the course, you will be able to apply machine learning techniques to real-world data analysis and visualization problems.",
                            Title = "Machine Learning for Data Analysis and Visualization"
                        });
                });

            modelBuilder.Entity("codeHub.Models.Course", b =>
                {
                    b.HasOne("codeHub.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
