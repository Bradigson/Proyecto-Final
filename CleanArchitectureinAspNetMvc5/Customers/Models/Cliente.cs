﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CleanArchitectureinAspNetMvc5.Customers.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
    }
}