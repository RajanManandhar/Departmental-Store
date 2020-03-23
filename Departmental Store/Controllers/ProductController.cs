using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Departmental_Store.Data;
using Departmental_Store.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Departmental_Store.Controllers
{ 
    public class ProductController : Controller
{
    DepartmentalDbContext _context;
    public ProductController(DepartmentalDbContext context)
    {
        _context = context;
    }




        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index(string searchString)
        {
            var product = from v in _context.Product
                          select v;
            if (!String.IsNullOrEmpty(searchString))
            {
                product = product.Where(s => s.ProductName.Contains(searchString));


            }

            /*
                        List < Product > locallist = _context.Product.ToList();
                        return View(locallist);*/

            return View(await product.ToListAsync());

        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product data)
        {
            if (ModelState.IsValid)
            {

                _context.Add(data);
                _context.SaveChanges();

                return RedirectToAction("Index");

            }
            return View("Index", data);

        }
    }
}
