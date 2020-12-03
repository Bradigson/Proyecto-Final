using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CleanArchitectureinAspNetMvc5.Products.Models;

namespace CleanArchitectureinAspNetMvc5.Products.Controllers
{
    public class ProductsController : Controller
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product { Id = 1,Name="carro",  Price = "$123414" },
            new Product {Id = 2, Name="camion",  Price = "$685234528" }
        };

        public ActionResult Index()
        {
            return View(_products);
        }
        public ActionResult Details(int id)
        {
            var product = _products
                .First(p => p.Id == id);
            return View(product);
        }

    }
}