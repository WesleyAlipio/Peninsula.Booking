using Microsoft.EntityFrameworkCore;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain
{
    public class BookingDBContext : DbContext
    {
        public BookingDBContext(DbContextOptions<BookingDBContext> options)
            : base(options) { }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<GuestRes> GuestRess { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<Billing> billings = new List<Billing>()
            {
                new Billing()
                {
                    BillingID = Guid.Parse("0371d081-26bc-4030-a7f1-25e938107aab"),
                    ReservationID = Guid.Parse("30efaed0-bc0a-4054-ae66-1d06d9a56d3f"),
                    UserID = Guid.Parse("d6f01585-5d6a-44ff-aaad-2d8648268582"),
                    RentCharges = 2500,
                    MiscCharges = 0,
                    TotalAmount = 2500
                },

                new Billing()
                {
                    BillingID = Guid.Parse("9b4bca62-c933-4441-a7cb-92c80cd1f514"),
                    ReservationID = Guid.Parse("1abb6429-1b32-4dc1-bcaf-d027dd9c8d49"),
                    UserID = Guid.Parse("aca4e15f-379b-44ce-90c0-ce8374cd0cd7"),
                    RentCharges = 2500,
                    MiscCharges = 250,
                    TotalAmount = 2750
                },

                new Billing()
                {
                    BillingID = Guid.Parse("c6e3abc9-7e6b-4191-8e50-ada7aa68431c"),
                    ReservationID = Guid.Parse("f6b5c368-0c2f-4993-bcdc-62a0ed41976a"),
                    UserID = Guid.Parse("78c8f95d-e520-4d53-9c8a-d438069b255c"),
                    RentCharges = 4000,
                    MiscCharges = 0,
                    TotalAmount = 4000
                },

                new Billing()
                {
                    BillingID = Guid.Parse("a85d1484-7884-4b7c-a332-0059c88d7a82"),
                    ReservationID = Guid.Parse("4cd68f22-2f65-49a3-a861-df13c55cc166"),
                    UserID = Guid.Parse("271dde75-f1e8-4fde-853c-9cdc75c0024c"),
                    RentCharges = 3200,
                    MiscCharges = 0,
                    TotalAmount = 3200
                },

                new Billing()
                {
                    BillingID = Guid.Parse("bc9c8abc-b272-45b8-99ce-a5e440c8a961"),
                    ReservationID = Guid.Parse("50324933-5ecc-4bac-b565-4af516064b4b"),
                    UserID = Guid.Parse("26e72e2c-f5e8-40dc-b66b-c1f675cb9066"),
                    RentCharges = 4500,
                    MiscCharges = 1500,
                    TotalAmount = 6000
                }
            };

            modelBuilder.Entity<Billing>()
                        .HasData(billings);

            List<Facility> facilities = new List<Facility>()
            {
                new Facility()
                {
                    FacilityID = Guid.Parse("4bb91a98-763b-4695-adad-6b977183a8c0"),
                    Name = "Gazebo 1",
                    Description = "Facility Sample 1",
                    Rates = 600,
                    Occupants = "8",
                    Type = Models.Enums.FacilityType.Cottage
                },

                new Facility()
                {
                    FacilityID = Guid.Parse("51153cf9-e514-466c-87e8-44c52e965ef2"),
                    Name = "Gazebo 2",
                    Description = "Facility Sample 2",
                    Rates = 800,
                    Occupants = "10",
                    Type = Models.Enums.FacilityType.Cottage
                },

                new Facility()
                {
                    FacilityID = Guid.Parse("9fd61b8f-3232-424b-a2f6-27244c8fe3b0"),
                    Name = "Alejandro",
                    Description = "Facility Sample 3",
                    Rates = 1750,
                    Occupants = "7",
                    Type = Models.Enums.FacilityType.Room

                },

                new Facility()
                {
                    FacilityID = Guid.Parse("0996cefb-09e8-4dfd-bd89-cd9bf76e6ba1"),
                    Name = "Althea",
                    Description = "Facility Sample 4",
                    Rates = 1750,
                    Occupants = "7",
                    Type = Models.Enums.FacilityType.Room
                },
                new Facility()
                {
                    FacilityID = Guid.Parse("697237fb-937e-4b26-99a0-e0308faca048"),
                    Name = "Villa D",
                    Description = "Facility Sample 5",
                    Rates = 1750,
                    Occupants = "7",
                    Type = Models.Enums.FacilityType.Room
                },

                new Facility()
                {
                    FacilityID = Guid.Parse("0530421c-18d9-4c94-a411-f01b47e5810b"),
                    Name = "Armando",
                    Description = "Facility Sample 6",
                    Rates = 30000,
                    Occupants = "50",
                    Type = Models.Enums.FacilityType.Venue
                },

                new Facility()
                {
                    FacilityID = Guid.Parse("86499198-0893-43b1-adea-2317969e5488"),
                    Name = "Amanda" +
                    "",
                    Description = "Facility Sample 7",
                    Rates = 45000,
                    Occupants = "80",
                    Type = Models.Enums.FacilityType.Venue
                }
            };

            modelBuilder.Entity<Facility>()
                        .HasData(facilities);


            List<User> users = new List<User>()
            {
                new User()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = DateTime.Parse("11/12/2020"),
                    Email = "JohnJohn@Doemail.com",
                    PhoneNumber = "09485209870",
                    Address = "Orani, Bataan",
                    Password = "SangeYasha",
                    Role = Models.Enums.Role.Admin,
                    Sex = Models.Enums.Sex.Male,
                    UserID = Guid.Parse("d6f01585-5d6a-44ff-aaad-2d8648268582")
                },

                new User()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    BirthDate = DateTime.Parse("5/8/1010"),
                    Email = "JaneJane@Doemail.com",
                    PhoneNumber = "09485209870",
                    Address = "Dinalupihan, Bataan",
                    Password = "MantaStyle",
                    Role = Models.Enums.Role.Admin, 
                    Sex = Models.Enums.Sex.Female,
                    UserID = Guid.Parse("aca4e15f-379b-44ce-90c0-ce8374cd0cd7")
                }

            };

            modelBuilder.Entity<User>()
                        .HasData(users);

            List<Reservation> reservations = new List<Reservation>()
            {
                new Reservation()
                {
                    FacilityType = FacilityType.Room,
                    CheckIn = DateTime.Parse("01/06/2020"),
                    CheckOut = DateTime.Parse("01/10/2020"),
                    FacilityID = Guid.Parse("697237fb-937e-4b26-99a0-e0308faca048"),
                    ReservationID =Guid.NewGuid(),
                    UserID = Guid.Parse("aca4e15f-379b-44ce-90c0-ce8374cd0cd7")
                },
                new Reservation()
                {
                    FacilityType = FacilityType.Room,
                    CheckIn = DateTime.Parse("01/10/2020"),
                    CheckOut = DateTime.Parse("01/12/2020"),
                    FacilityID = Guid.Parse("0996cefb-09e8-4dfd-bd89-cd9bf76e6ba1"),
                    ReservationID =Guid.NewGuid(),
                    UserID = Guid.Parse("aca4e15f-379b-44ce-90c0-ce8374cd0cd7")
                }
            };
            modelBuilder.Entity<Reservation>()
                        .HasData(reservations);
        }
    }
}
