using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Departmental_Store.Models;
using Departmental_Store.Data;

namespace Departmental_Store.Controllers
{
    public class HomeController : Controller
    {
        private DepartmentalDbContext db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(DepartmentalDbContext _db ,ILogger<HomeController> logger)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([FromForm]Admin login , User user)
        {
            if (login.admin)
            {
                if (db.Admins.Where(b => b.userName == login.userName && b.userPassword == login.userPassword).FirstOrDefault() == null)
                {
                    return View();

                }
                else
                {     
                    return View("~/Views/Admin/Index.cshtml");
                }
            }
            else
            {
                login.userName = user.userName;
                login.userPassword = user.userPassword;
                if (db.Users.Where(c => c.userName == user.userName && c.userPassword == user.userPassword).FirstOrDefault() == null)
                {

                    return View();

                }
                else
                {

                    return View("~/Views/User/Index.cshtml");
                }
            }
            
        }

    }
}
