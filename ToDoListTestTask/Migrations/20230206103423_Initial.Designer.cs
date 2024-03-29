﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoListTestTask.Data;

#nullable disable

namespace ToDoListTestTask.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230206103423_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("ToDoListTestTask.Models.ToDoList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTimeCreating")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ToDoLists");
                });
#pragma warning restore 612, 618
        }
    }
}
