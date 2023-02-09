﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TWTodolist.Contexts;

#nullable disable

namespace TWTodolist.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TWTodolist.Models.ToDo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<bool>("iscompleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_completed");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("title");

                    b.HasKey("id");

                    b.ToTable("todo", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
