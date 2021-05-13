using CoffeeshopRegistration2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeshopRegistration2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Customers> result = new List<Customers>();
            using (var context = new CustomerContext())
            {
                result = context.Customer.ToList();
            }
            return View(result);
        }

        public IActionResult SaveCustomers(Customers cu)
        {
            using (var context = new CustomerContext())
            {
                context.Customer.Add(cu);
                context.SaveChanges();
            }
            return Redirect("/");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Review()
        {
            return View();
        }

        public IActionResult UserList()
        {
            List<Customers> customers = new List<Customers>();
            using (var context = new CustomerContext())
            {
                customers = context.Customer.ToList();
            }
            return View(customers);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
