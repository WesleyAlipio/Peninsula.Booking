using Microsoft.AspNetCore.Mvc;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models;
using PeninsulaHotelAndResortBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeninsulaHotelAndResortBookingSystem.Controllers
{
    public class RentalsController : Controller
    {
        private readonly BookingDBContext _context;
        public RentalsController(BookingDBContext context)
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
            Paged <Facility> facilities = new Paged<Facility>();

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
    }
}
