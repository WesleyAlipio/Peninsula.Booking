using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeninsulaHotelAndResortBookingSystem.Models
{
    public class FacilitySearchViewModel
    {
        public Paged<FacilityViewModel> Facilities { get; set; }
    }

    public class FacilityViewModel : Facility
    {

    }
}
