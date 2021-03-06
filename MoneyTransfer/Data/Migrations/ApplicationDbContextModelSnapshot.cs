﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoneyTransfer.Data;

namespace MoneyTransfer.Data.Migrations
{
    [DbContext(typeof(MoneyTransferContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("MoneyTransfer.Data.Entity.Transaction", b =>
                {
                    b.Property<int>("Id_Transaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount_Receiver")
                        .HasColumnType("int");

                    b.Property<int>("Amount_Sender")
                        .HasColumnType("int");

                    b.Property<int>("Currency_Receiver")
                        .HasColumnType("int");

                    b.Property<int>("Currency_Sender")
                        .HasColumnType("int");

                    b.Property<int>("Id_Receiver")
                        .HasColumnType("int");

                    b.Property<int>("Id_Sender")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Transaction_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Transaction_State")
                        .HasColumnType("int");

                    b.HasKey("Id_Transaction");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
