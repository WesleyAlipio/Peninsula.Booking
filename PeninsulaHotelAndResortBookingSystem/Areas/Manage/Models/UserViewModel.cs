using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeninsulaHotelAndResortBookingSystem.Areas.Manage.Models
{
    public class UserSearchViewModel : User
    { 
        public Paged<UserViewModel> Users { get; set; }
    }
    public class UserViewModel : User
    {
        public string FullName
        {
            get
            {
                return (this.FirstName + " " + this.LastName);
            }
        }
    }
}
