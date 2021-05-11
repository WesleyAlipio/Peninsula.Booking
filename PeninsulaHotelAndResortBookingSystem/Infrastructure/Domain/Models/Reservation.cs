using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models
{
    public class Reservation
    {
        public Guid?            ReservationID       { get; set; }
        public Guid?            UserID              { get; set; }
        public Guid?            FacilityID          { get; set; }
        public FacilityType     FacilityType        { get; set; }
        public DateTime         CheckIn             { get; set; }
        public DateTime         CheckOut            { get; set; }
    }
}
