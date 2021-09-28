﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrationApp.DbContexts;

namespace RegistrationApp.Migrations
{
    [DbContext(typeof(RegistrationContext))]
    partial class RegistrationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RegistrationApp.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ClientCreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ClientDesc")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("ClientIsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ClientModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("ClientId");

                    b.ToTable("mstClient", "dbo");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            ClientCode = "MrGreen",
                            ClientCreatedOn = new DateTime(2021, 9, 24, 19, 18, 55, 166, DateTimeKind.Local).AddTicks(880),
                            ClientDesc = "Mr Green",
                            ClientIsActive = true,
                            ClientName = "Mr Green"
                        },
                        new
                        {
                            ClientId = 2,
                            ClientCode = "RedBat",
                            ClientCreatedOn = new DateTime(2021, 9, 24, 19, 18, 55, 167, DateTimeKind.Local).AddTicks(818),
                            ClientDesc = "Red Bat",
                            ClientIsActive = true,
                            ClientName = "Red Bat"
                        });
                });

            modelBuilder.Entity("RegistrationApp.Entities.UsersDetail", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<string>("FavoriteFootBallTeam")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PersonalNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("UserID");

                    b.HasIndex("ClientID");

                    b.ToTable("mstUsersDetail", "dbo");
                });

            modelBuilder.Entity("RegistrationApp.Entities.UsersDetail", b =>
                {
                    b.HasOne("RegistrationApp.Entities.Client", "Clients")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}