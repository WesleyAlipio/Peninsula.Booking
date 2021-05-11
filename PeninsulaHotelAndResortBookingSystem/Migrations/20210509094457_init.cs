using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeninsulaHotelAndResortBookingSystem.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Billings",
                columns: table => new
                {
                    BillingID = table.Column<Guid>(nullable: false),
                    UserID = table.Column<Guid>(nullable: true),
                    ReservationID = table.Column<Guid>(nullable: true),
                    RentCharges = table.Column<int>(nullable: false),
                    MiscCharges = table.Column<int>(nullable: false),
                    TotalAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billings", x => x.BillingID);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    FacilityID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Rates = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Occupants = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.FacilityID);
                });

            migrationBuilder.CreateTable(
                name: "GuestRess",
                columns: table => new
                {
                    GuestResID = table.Column<Guid>(nullable: false),
                    GuestID = table.Column<Guid>(nullable: true),
                    FacilityID = table.Column<Guid>(nullable: true),
                    FacilityType = table.Column<int>(nullable: false),
                    CheckIn = table.Column<DateTime>(nullable: false),
                    CheckOut = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestRess", x => x.GuestResID);
                });

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    GuestID = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.GuestID);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationID = table.Column<Guid>(nullable: false),
                    UserID = table.Column<Guid>(nullable: true),
                    FacilityID = table.Column<Guid>(nullable: true),
                    FacilityType = table.Column<int>(nullable: false),
                    CheckIn = table.Column<DateTime>(nullable: false),
                    CheckOut = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Sex = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.InsertData(
                table: "Billings",
                columns: new[] { "BillingID", "MiscCharges", "RentCharges", "ReservationID", "TotalAmount", "UserID" },
                values: new object[,]
                {
                    { new Guid("0371d081-26bc-4030-a7f1-25e938107aab"), 0, 2500, new Guid("30efaed0-bc0a-4054-ae66-1d06d9a56d3f"), 2500, new Guid("d6f01585-5d6a-44ff-aaad-2d8648268582") },
                    { new Guid("9b4bca62-c933-4441-a7cb-92c80cd1f514"), 250, 2500, new Guid("1abb6429-1b32-4dc1-bcaf-d027dd9c8d49"), 2750, new Guid("aca4e15f-379b-44ce-90c0-ce8374cd0cd7") },
                    { new Guid("c6e3abc9-7e6b-4191-8e50-ada7aa68431c"), 0, 4000, new Guid("f6b5c368-0c2f-4993-bcdc-62a0ed41976a"), 4000, new Guid("78c8f95d-e520-4d53-9c8a-d438069b255c") },
                    { new Guid("a85d1484-7884-4b7c-a332-0059c88d7a82"), 0, 3200, new Guid("4cd68f22-2f65-49a3-a861-df13c55cc166"), 3200, new Guid("271dde75-f1e8-4fde-853c-9cdc75c0024c") },
                    { new Guid("bc9c8abc-b272-45b8-99ce-a5e440c8a961"), 1500, 4500, new Guid("50324933-5ecc-4bac-b565-4af516064b4b"), 6000, new Guid("26e72e2c-f5e8-40dc-b66b-c1f675cb9066") }
                });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilityID", "Description", "Name", "Occupants", "Rates", "Type" },
                values: new object[,]
                {
                    { new Guid("4bb91a98-763b-4695-adad-6b977183a8c0"), "Facility Sample 1", "Gazebo 1", "8", 600, 0 },
                    { new Guid("51153cf9-e514-466c-87e8-44c52e965ef2"), "Facility Sample 2", "Gazebo 2", "10", 800, 0 },
                    { new Guid("9fd61b8f-3232-424b-a2f6-27244c8fe3b0"), "Facility Sample 3", "Alejandro", "7", 1750, 1 },
                    { new Guid("0996cefb-09e8-4dfd-bd89-cd9bf76e6ba1"), "Facility Sample 4", "Althea", "7", 1750, 1 },
                    { new Guid("697237fb-937e-4b26-99a0-e0308faca048"), "Facility Sample 5", "Villa D", "7", 1750, 1 },
                    { new Guid("0530421c-18d9-4c94-a411-f01b47e5810b"), "Facility Sample 6", "Armando", "50", 30000, 2 },
                    { new Guid("86499198-0893-43b1-adea-2317969e5488"), "Facility Sample 7", "Amanda", "80", 45000, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationID", "CheckIn", "CheckOut", "FacilityID", "FacilityType", "UserID" },
                values: new object[,]
                {
                    { new Guid("4c5c4e44-d896-4e13-afd0-dd0fcea527fa"), new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("697237fb-937e-4b26-99a0-e0308faca048"), 1, new Guid("aca4e15f-379b-44ce-90c0-ce8374cd0cd7") },
                    { new Guid("bbe558ad-09e2-454c-9d97-6c3e2cbeb16e"), new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0996cefb-09e8-4dfd-bd89-cd9bf76e6ba1"), 1, new Guid("aca4e15f-379b-44ce-90c0-ce8374cd0cd7") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Address", "BirthDate", "Email", "FirstName", "LastName", "Password", "PhoneNumber", "Role", "Sex" },
                values: new object[,]
                {
                    { new Guid("d6f01585-5d6a-44ff-aaad-2d8648268582"), "Orani, Bataan", new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "JohnJohn@Doemail.com", "John", "Doe", "SangeYasha", "09485209870", 1, 0 },
                    { new Guid("aca4e15f-379b-44ce-90c0-ce8374cd0cd7"), "Dinalupihan, Bataan", new DateTime(1010, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "JaneJane@Doemail.com", "Jane", "Doe", "MantaStyle", "09485209870", 1, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Billings");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "GuestRess");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
