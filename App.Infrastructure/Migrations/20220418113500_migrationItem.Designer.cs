﻿// <auto-generated />
using System;
using App.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220418113500_migrationItem")]
    partial class migrationItem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("App.Domain.Entities.Item", b =>
                {
                    b.Property<long>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("itemid")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedDatetime")
                        .HasColumnType("datetime2")
                        .HasColumnName("createddatetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("isdeleted");

                    b.Property<int>("ItemType")
                        .HasColumnType("int")
                        .HasColumnName("type");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDatetime")
                        .HasColumnType("datetime2")
                        .HasColumnName("updateddatetime");

                    b.Property<bool>("isFavourite")
                        .HasColumnType("bit")
                        .HasColumnName("isfavourite");

                    b.HasKey("ItemId");

                    b.ToTable("item");
                });
#pragma warning restore 612, 618
        }
    }
}
