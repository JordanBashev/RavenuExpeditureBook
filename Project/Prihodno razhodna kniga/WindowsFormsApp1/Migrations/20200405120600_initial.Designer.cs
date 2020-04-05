﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Migrations
{
    [DbContext(typeof(ApplicationContexts))]
    [Migration("20200405120600_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WindowsFormsApp1.Data.Models.PersonAccount", b =>
                {
                    b.Property<int>("PersonRegistersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonBookTypesId")
                        .HasColumnType("int");

                    b.HasKey("PersonRegistersId");

                    b.HasIndex("PersonBookTypesId");

                    b.ToTable("PersonAccounts");
                });

            modelBuilder.Entity("WindowsFormsApp1.Data.Models.PersonBookType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonAccountId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PersonBookTypes");
                });

            modelBuilder.Entity("WindowsFormsApp1.Data.Models.PersonRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonRegisters");
                });

            modelBuilder.Entity("WindowsFormsApp1.Data.Models.RevenueExpenditureBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountRavenueBookId")
                        .HasColumnType("int");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CheckOutPlusAndMinus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Counted")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Expense")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Income")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RawMaterials")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserRegisteredId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountRavenueBookId");

                    b.HasIndex("UserRegisteredId");

                    b.ToTable("RevenueExpenditureBooks");
                });

            modelBuilder.Entity("WindowsFormsApp1.Data.Models.PersonAccount", b =>
                {
                    b.HasOne("WindowsFormsApp1.Data.Models.PersonBookType", "PersonBook")
                        .WithMany()
                        .HasForeignKey("PersonBookTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WindowsFormsApp1.Data.Models.RevenueExpenditureBook", b =>
                {
                    b.HasOne("WindowsFormsApp1.Data.Models.PersonBookType", "PersonBookType")
                        .WithMany()
                        .HasForeignKey("AccountRavenueBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WindowsFormsApp1.Data.Models.PersonRegister", "UserRegisterId")
                        .WithMany()
                        .HasForeignKey("UserRegisteredId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
