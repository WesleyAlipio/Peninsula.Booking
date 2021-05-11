using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models
{
    public class Billing
    {
        public Guid? BillingID { get; set; }
        public Guid? UserID { get; set; }
        public Guid? ReservationID { get; set; }
        public int RentCharges { get; set; }
        public int MiscCharges { get; set; }
        public int TotalAmount { get; set; }
    }
}
