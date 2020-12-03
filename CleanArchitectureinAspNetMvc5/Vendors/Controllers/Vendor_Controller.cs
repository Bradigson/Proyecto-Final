using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CleanArchitectureinAspNetMvc5.Vendors.Models;

namespace CleanArchitectureinAspNetMvc5.Vendors.Controllers
{
    public class Vendor_Controller : Controller
    {
        private readonly List<Vendedor> _vendor = new List<Vendedor>
        {
            new Vendedor {id=1, nombre="jose", edad=32 },
            new Vendedor {id=2, nombre="jose", edad=23 }
        };

        public ActionResult Index()
        {
            return View(_vendor);
        }
        public ActionResult Details(int id)
        {
            var vendor = _vendor
                .First(p => p.id == id);
            return View(vendor);
        }

    }
}