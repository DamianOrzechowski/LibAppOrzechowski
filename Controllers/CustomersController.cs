using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibAppOrzechowski.Models;
using LibAppOrzechowski.ViewModels;

namespace LibAppOrzechowski.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);

        }
        public IActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return Content("User not found");
            }

            return View(customer);

        }

        private IEnumerable<Customer> GetCustomers()
        {
            

            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Aneta Walczak" },
                new Customer { Id = 2, Name = "Jakub Nowak"}




            };
        }

    }
}
