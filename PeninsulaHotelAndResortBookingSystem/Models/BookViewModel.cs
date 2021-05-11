using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeninsulaHotelAndResortBookingSystem.Models
{
    public class BookViewModel
    {
        public Guid? FacilityID { get; set; }
        public FacilityType FacilityType { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
