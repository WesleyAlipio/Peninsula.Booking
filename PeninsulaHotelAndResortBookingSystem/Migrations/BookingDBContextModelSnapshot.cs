﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain;

namespace PeninsulaHotelAndResortBookingSystem.Migrations
{
    [DbContext(typeof(BookingDBContext))]
    partial class BookingDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.Billing", b =>
                {
                    b.Property<Guid?>("BillingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("MiscCharges")
                        .HasColumnType("int");

                    b.Property<int>("RentCharges")
                        .HasColumnType("int");

                    b.Property<Guid?>("ReservationID")
                        .HasColumnType("char(36)");

                    b.Property<int>("TotalAmount")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserID")
                        .HasColumnType("char(36)");

                    b.HasKey("BillingID");

                    b.ToTable("Billings");

                    b.HasData(
                        new
                        {
                            BillingID = new Guid("0371d081-26bc-4030-a7f1-25e938107aab"),
                            MiscCharges = 0,
                            RentCharges = 2500,
                            ReservationID = new Guid("30efaed0-bc0a-4054-ae66-1d06d9a56d3f"),
                            TotalAmount = 2500,
                            UserID = new Guid("d6f01585-5d6a-44ff-aaad-2d8648268582")
                        },
                        new
                        {
                            BillingID = new Guid("9b4bca62-c933-4441-a7cb-92c80cd1f514"),
                            MiscCharges = 250,
                            RentCharges = 2500,
                            ReservationID = new Guid("1abb6429-1b32-4dc1-bcaf-d027dd9c8d49"),
                            TotalAmount = 2750,
                            UserID = new Guid("aca4e15f-379b-44ce-90c0-ce8374cd0cd7")
                        },
                        new
                        {
                            BillingID = new Guid("c6e3abc9-7e6b-4191-8e50-ada7aa68431c"),
                            MiscCharges = 0,
                            RentCharges = 4000,
                            ReservationID = new Guid("f6b5c368-0c2f-4993-bcdc-62a0ed41976a"),
                            TotalAmount = 4000,
                            UserID = new Guid("78c8f95d-e520-4d53-9c8a-d438069b255c")
                        },
                        new
                        {
                            BillingID = new Guid("a85d1484-7884-4b7c-a332-0059c88d7a82"),
                            MiscCharges = 0,
                            RentCharges = 3200,
                            ReservationID = new Guid("4cd68f22-2f65-49a3-a861-df13c55cc166"),
                            TotalAmount = 3200,
                            UserID = new Guid("271dde75-f1e8-4fde-853c-9cdc75c0024c")
                        },
                        new
                        {
                            BillingID = new Guid("bc9c8abc-b272-45b8-99ce-a5e440c8a961"),
                            MiscCharges = 1500,
                            RentCharges = 4500,
                            ReservationID = new Guid("50324933-5ecc-4bac-b565-4af516064b4b"),
                            TotalAmount = 6000,
                            UserID = new Guid("26e72e2c-f5e8-40dc-b66b-c1f675cb9066")
                        });
                });

            modelBuilder.Entity("PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.Facility", b =>
                {
                    b.Property<Guid?>("FacilityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Occupants")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rates")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("FacilityID");

                    b.ToTable("Facilities");

                    b.HasData(
                        new
                        {
                            FacilityID = new Guid("4bb91a98-763b-4695-adad-6b977183a8c0"),
                            Description = "Facility Sample 1",
                            Name = "Gazebo 1",
                            Occupants = "8",
                            Rates = 600,
                            Type = 0
                        },
                        new
                        {
                            FacilityID = new Guid("51153cf9-e514-466c-87e8-44c52e965ef2"),
                            Description = "Facility Sample 2",
                            Name = "Gazebo 2",
                            Occupants = "10",
                            Rates = 800,
                            Type = 0
                        },
                        new
                        {
                            FacilityID = new Guid("9fd61b8f-3232-424b-a2f6-27244c8fe3b0"),
                            Description = "Facility Sample 3",
                            Name = "Alejandro",
                            Occupants = "7",
                            Rates = 1750,
                            Type = 1
                        },
                        new
                        {
                            FacilityID = new Guid("0996cefb-09e8-4dfd-bd89-cd9bf76e6ba1"),
                            Description = "Facility Sample 4",
                            Name = "Althea",
                            Occupants = "7",
                            Rates = 1750,
                            Type = 1
                        },
                        new
                        {
                            FacilityID = new Guid("697237fb-937e-4b26-99a0-e0308faca048"),
                            Description = "Facility Sample 5",
                            Name = "Villa D",
                            Occupants = "7",
                            Rates = 1750,
                            Type = 1
                        },
                        new
                        {
                            FacilityID = new Guid("0530421c-18d9-4c94-a411-f01b47e5810b"),
                            Description = "Facility Sample 6",
                            Name = "Armando",
                            Occupants = "50",
                            Rates = 30000,
                            Type = 2
                        },
                        new
                        {
                            FacilityID = new Guid("86499198-0893-43b1-adea-2317969e5488"),
                            Description = "Facility Sample 7",
                            Name = "Amanda",
                            Occupants = "80",
                            Rates = 45000,
                            Type = 2
                        });
                });

            modelBuilder.Entity("PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.Guest", b =>
                {
                    b.Property<Guid?>("GuestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.HasKey("GuestID");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.GuestRes", b =>
                {
                    b.Property<Guid?>("GuestResID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("FacilityID")
                        .HasColumnType("char(36)");

                    b.Property<int>("FacilityType")
                        .HasColumnType("int");

                    b.Property<Guid?>("GuestID")
                        .HasColumnType("char(36)");

                    b.HasKey("GuestResID");

                    b.ToTable("GuestRess");
                });

            modelBuilder.Entity("PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.Reservation", b =>
                {
                    b.Property<Guid?>("ReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("FacilityID")
                        .HasColumnType("char(36)");

                    b.Property<int>("FacilityType")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserID")
                        .HasColumnType("char(36)");

                    b.HasKey("ReservationID");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationID = new Guid("4c5c4e44-d896-4e13-afd0-dd0fcea527fa"),
                            CheckIn = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FacilityID = new Guid("697237fb-937e-4b26-99a0-e0308faca048"),
                            FacilityType = 1,
                            UserID = new Guid("aca4e15f-379b-44ce-90c0-ce8374cd0cd7")
                        },
                        new
                        {
                            ReservationID = new Guid("bbe558ad-09e2-454c-9d97-6c3e2cbeb16e"),
                            CheckIn = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CheckOut = new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FacilityID = new Guid("0996cefb-09e8-4dfd-bd89-cd9bf76e6ba1"),
                            FacilityType = 1,
                            UserID = new Guid("aca4e15f-379b-44ce-90c0-ce8374cd0cd7")
                        });
                });

            modelBuilder.Entity("PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.User", b =>
                {
                    b.Property<Guid?>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = new Guid("d6f01585-5d6a-44ff-aaad-2d8648268582"),
                            Address = "Orani, Bataan",
                            BirthDate = new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "JohnJohn@Doemail.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Password = "SangeYasha",
                            PhoneNumber = "09485209870",
                            Role = 1,
                            Sex = 0
                        },
                        new
                        {
                            UserID = new Guid("aca4e15f-379b-44ce-90c0-ce8374cd0cd7"),
                            Address = "Dinalupihan, Bataan",
                            BirthDate = new DateTime(1010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "JaneJane@Doemail.com",
                            FirstName = "Jane",
                            LastName = "Doe",
                            Password = "MantaStyle",
                            PhoneNumber = "09485209870",
                            Role = 1,
                            Sex = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}