using Microsoft.AspNetCore.Mvc;
using PeninsulaHotelAndResortBookingSystem.Areas.Manage.Models;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain;
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeninsulaHotelAndResortBookingSystem.Areas.Manage.Controllers
{
    [Area ("manage")]
    public class UsersController : Controller
    {
        private readonly BookingDBContext _context;
        public UsersController(BookingDBContext context)
        {
            _context = context;
        }

        [HttpGet, Route("~/Manage/Users")]
        public IActionResult Index(int pageIndex = 1,
                                    int pageSize = 10,
                                    string sortBy = "FirstName",
                                    string sortOrder = "asc",
                                    string keyword = "")
        {
            IQueryable<User> allUsers = _context.Users.AsQueryable();
            Paged<User> users = new Paged<User>();

            if (!string.IsNullOrEmpty(keyword))
            {
                allUsers = allUsers.Where(f => f.FirstName.Contains(keyword) || f.LastName.Contains(keyword) || f.Email.Contains(keyword));
            }

            var queryCount = allUsers.Count();
            var skip = pageSize * (pageIndex - 1);

            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (sortBy.ToLower() == "firstname" && sortOrder.ToLower() == "asc")
            {
                users.Items = allUsers.OrderBy(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }

            if (sortBy.ToLower() == "firstname" && sortOrder.ToLower() == "desc")
            {
                users.Items = allUsers.OrderByDescending(e => e.FirstName).Skip(skip).Take(pageSize).ToList();
            }

            if (sortBy.ToLower() == "lastname" && sortOrder.ToLower() == "asc")
            {
                users.Items = allUsers.OrderBy(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }

            if (sortBy.ToLower() == "lastname" && sortOrder.ToLower() == "desc")
            {
                users.Items = allUsers.OrderByDescending(e => e.LastName).Skip(skip).Take(pageSize).ToList();
            }


            var result = new UserSearchViewModel();
            result.Users = new Paged<UserViewModel>();
            result.Users.Keyword = keyword;
            result.Users.PageCount = pageCount;
            result.Users.PageIndex = pageIndex;
            result.Users.PageSize = pageSize;
            result.Users.QueryCount = queryCount;

            result.Users.Items = new List<UserViewModel>();

            foreach (var user in users.Items)
            {
                result.Users.Items.Add(new UserViewModel()
                {
                    UserID = user.UserID,
                    Address = user.Address,
                    BirthDate = user.BirthDate,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Password = user.Password,
                    PhoneNumber = user.PhoneNumber,
                    Role = user.Role,
                    Sex = user.Sex
                });
            }



            return View(result);
        }
    }
}
