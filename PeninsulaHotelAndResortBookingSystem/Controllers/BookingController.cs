using Microsoft.AspNetCore.Mvc;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.Enums;
using PeninsulaHotelAndResortBookingSystem.Models;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Security;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeninsulaHotelAndResortBookingSystem.Controllers
{
    public class BookingController : Controller
    {


        private readonly BookingDBContext _context;
        public BookingController(BookingDBContext context)
        {
            _context = context;
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
            var dateIn = dateArr;
            var dateOut = dateDep;
            
            ViewBag.dateIn = dateArr;
            ViewBag.dateOut = dateDep;

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
            
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Error", "Required");
                return View(model);
            }
            Reservation reservation = new Reservation()
            { 
                FacilityID = model.FacilityID,
                ReservationID = Guid.NewGuid(),
                UserID = User.GetId(),
                FacilityType = model.FacilityType,
                CheckIn = model.CheckIn,
                CheckOut = model.CheckOut
            };
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
            return Redirect("~/");
        }
    }
}
