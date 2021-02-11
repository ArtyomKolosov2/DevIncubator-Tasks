﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Data
{
    public abstract class Product
    {
        public string ProductName { get; set; }
        protected Product()
        {
            ProductName = "product";
        }
        protected Product(string name)
        {
            ProductName = name;
        }
    }
}
