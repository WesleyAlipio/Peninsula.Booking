using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models
{
    public class Facility
    {
        public Guid? FacilityID { get; set; }
        public string Name { get; set; }
        public int Rates { get; set; }
        public string Description { get; set; }
        public string Occupants { get; set; }
        public Enums.FacilityType Type { get; set; }
    }
}
