using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GarageSale.Models;
using GarageSale.DataProviders;

namespace GarageSale.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            var products = ProductService.LoadProducts();
            return View(products);
        }

        public IActionResult Details(int Id)
        {
            var product = ProductService.LoadProducts().First(p => p.Id == Id);
            return View(product);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
