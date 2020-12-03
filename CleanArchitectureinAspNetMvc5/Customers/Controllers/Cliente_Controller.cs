using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CleanArchitectureinAspNetMvc5.Customers.Models;

namespace CleanArchitectureinAspNetMvc5.Customers.Controllers
{
    public class Cliente_Controller : Controller
    {
        private readonly List<Cliente> _client = new List<Cliente>
        {
          new Cliente {id=9, nombre="joel", edad=22 },
          new Cliente {id=1, nombre="ivana", edad=56 }
        };

        public ActionResult Index()
        {
            return View(_client);
        }
        public ActionResult Details(int id)
        {
            var cliente = _client
                .First(p => p.id == id);
            return View(cliente);
        }
    }
}