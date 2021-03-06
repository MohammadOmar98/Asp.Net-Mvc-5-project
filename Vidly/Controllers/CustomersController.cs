﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customers> GetCustomers()
        {
            return new List<Customers>
            {
                new Customers { Id = 1, Name = "John Smith" },
                new Customers { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}