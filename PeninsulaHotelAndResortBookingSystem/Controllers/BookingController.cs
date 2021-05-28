using Microsoft.AspNetCore.Mvc;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.Enums;
using PeninsulaHotelAndResortBookingSystem.Models;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Net.Mail;
using System.Net;

namespace PeninsulaHotelAndResortBookingSystem.Controllers
{
    public class BookingController : Controller
    {


        private readonly BookingDBContext _context;
        protected readonly IConfiguration _config;
        private string emailUserName;
        private string emailPassword;
        public BookingController(BookingDBContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
            var emailConfig = this._config.GetSection("Email");
            emailUserName = emailConfig["Username"].ToString();
            emailPassword = emailConfig["Password"].ToString();

        }
        public IActionResult Index(int pageIndex = 1,
                                    int pageSize = 10,
                                    string sortBy = "rates",
                                    string sortOrder = "asc",
                                    string keyword = "")
        {
            IQueryable<Facility> allFacilities = _context.Facilities.AsQueryable();
            Paged<Facility> facilities = new Paged<Facility>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allFacilities = allFacilities.Where(f => f.Name.Contains(keyword));
            }

            var queryCount = allFacilities.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "rates" && sortOrder.ToLower() == "asc")
            {
                facilities.Items = allFacilities.OrderBy(e => e.Rates).Skip(skip).Take(pageSize).ToList();
            }

            if (sortBy.ToLower() == "rates" && sortOrder.ToLower() == "desc")
            {
                facilities.Items = allFacilities.OrderByDescending(e => e.Rates).Skip(skip).Take(pageSize).ToList();
            }


            var result = new FacilitySearchViewModel();
            result.Facilities = new Paged<FacilityViewModel>();
            result.Facilities.Keyword = keyword;
            result.Facilities.PageCount = pageCount;
            result.Facilities.PageIndex = pageIndex;
            result.Facilities.PageSize = pageSize;
            result.Facilities.QueryCount = queryCount;

            result.Facilities.Items = new List<FacilityViewModel>();

            foreach (var facility in facilities.Items)
            {
                result.Facilities.Items.Add(new FacilityViewModel()
                {
                    FacilityID = facility.FacilityID,
                    Description = facility.Description,
                    Name = facility.Name,
                    Occupants = facility.Occupants,
                    Rates = facility.Rates,
                    Type = facility.Type
                });
            }
            return View(result);
        }


        //Overlapping Dates (StartA <= EndB) and(EndA >= StartB)

        public IActionResult RoomRes(DateTime dateArr, DateTime dateDep)
        {
            DateTime dateIn = dateArr;
            DateTime dateOut = dateDep;
            
            ViewBag.dateIn = dateArr.ToString();
            ViewBag.dateOut = dateDep.ToString();

            IQueryable<Facility> allFacilities = _context.Facilities.AsQueryable();
            IQueryable<Reservation> allReservations = _context.Reservations.AsQueryable();   
            
            List<Facility> facilities = new List<Facility>();
            List<Reservation> overlaps = new List<Reservation>();

            overlaps = allReservations.Where(r => r.FacilityType == FacilityType.Room && r.CheckIn < dateOut && r.CheckOut > dateIn).Distinct().ToList();

            if (overlaps.Count > 0)
            {
                foreach (var ol in overlaps)
                    facilities = allFacilities.Where(f => f.FacilityID != ol.FacilityID && f.Type == FacilityType.Room).ToList();
            }
            else
            {
                facilities = allFacilities.Where(f => f.Type == FacilityType.Room).ToList();
            }
            return View(facilities);
        }

        [HttpPost,Route("~/Booking/NewBook")]
        public IActionResult NewBook(BookViewModel model)
        {


            Guid rID = Guid.NewGuid();
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Error", "Required");
                return View(model);
            }
            Reservation reservation = new Reservation()
            { 
                FacilityID = model.FacilityID,
                ReservationID = rID,
                UserID = User.GetId(),
                FacilityType = model.FacilityType,
                CheckIn = model.CheckIn,
                CheckOut = model.CheckOut
            };
            Billing billing = new Billing()
            {
              UserID = User.GetId(),
              BillingID = Guid.NewGuid(),
              ReservationID = rID,
              TotalAmount = model.RentCharges,
              MiscCharges = 0,
              RentCharges = model.RentCharges,
            };
            _context.Reservations.Add(reservation);
            _context.Billings.Add(billing);
            _context.SaveChanges();
            this.SendNow("Hello " + this.User.GetFullName() + "Thank you for Booking in Peninsula Hotel and Resort" +  "Check In:" + model.CheckIn  + "Check Out:" + model.CheckOut + "Payment:" + model.RentCharges, this.User.GetEmailAddress(), "Peninsula Confirmed Reservation", "Thank you for making a Reservation in Peninsula!");
            return Redirect("~/");
        }

        public IActionResult confirmBooking(DateTime dateArr, DateTime dateDep, Guid RoomID) 
        {
            DateTime dateIn = dateArr;
            DateTime dateOut = dateDep;

            ViewBag.dateIn = dateArr.ToString();
            ViewBag.dateOut = dateDep.ToString();

            int rates;
            String totalDays = (dateDep - dateArr).TotalDays.ToString();
            IQueryable<Facility> facility = _context.Facilities.AsQueryable();
            
            rates = facility.Where(f => f.FacilityID == RoomID).Select(f => f.Rates).FirstOrDefault();
            int totalAmount = rates * int.Parse(totalDays);
            facility = facility.Where(f => f.FacilityID == RoomID);
            var model = facility.ToList();
            ViewBag.bookDays = totalDays;
            ViewBag.amount = totalAmount;
            return View(model);
        }

        private void SendNow(string message, string messageTo, string messageName, string emailSubject)
        {
            var fromAddress = new MailAddress(emailUserName, "CSM Bataan Apps");
            string body = message;


            ///https://support.google.com/accounts/answer/6010255?hl=en
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, emailPassword),
                Timeout = 20000
            };

            var toAddress = new MailAddress(messageTo, messageName);

            smtp.Send(new MailMessage(fromAddress, toAddress)
            {
                Subject = emailSubject,
                Body = body,
                IsBodyHtml = true
            });
        }
    }
}
