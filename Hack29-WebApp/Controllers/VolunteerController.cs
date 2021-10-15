
using Hack29_WebApp.DatabaseLayer;
using Hack29_WebApp.DatabaseLayer.Models;
using Hack29_WebApp.Repositories;
using Hack29_WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hack29_WebApp.Controllers
{
    public class VolunteerController : Controller
    {
        public IActionResult Index()
        {

            //GET: /users
            ReportingService rs = new ReportingService();

            List<User> uList = rs.GetAllUsers();
            ViewData["users"] = uList;
            return View();
        }
    }
}
