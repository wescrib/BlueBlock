using BlueBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlueBox.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult CustomerList()
        {
            IEnumerable<Customer> c = ViewCustomers();

            return View(c);
        }

        private IEnumerable<Customer> ViewCustomers()
        {
            IEnumerable<Customer> list = new List<Customer>
            {
                new Customer { Id = 1, Name="William Reginald" },
                new Customer { Id = 2, Name="Emily Olsen" }
            };

            return list;
        }

        public ActionResult OneCustomer(int id)
        {
            Customer cus = ViewCustomers().SingleOrDefault(c => c.Id == id);

            if(cus == null)
            {
                return HttpNotFound();
            }

            return View(cus);
        }
    }
}