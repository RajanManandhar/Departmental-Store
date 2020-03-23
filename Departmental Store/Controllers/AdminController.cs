using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Departmental_Store.Controllers
{
    public class AdminController : Controller
    {
     
             public IActionResult Index()
        {
            return View();
        }
    }
}
