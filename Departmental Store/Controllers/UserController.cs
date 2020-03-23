using Departmental_Store.Data;
using Departmental_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Departmental_Store.Controllers
{
    public class UserController : Controller
    {
        private DepartmentalDbContext db;
        public UserController(DepartmentalDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
