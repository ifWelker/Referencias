﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLinq.Entities;

namespace DemoLinq.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Price.ToString("F2")
                + ", "
                + Category.Tier;
        }
    }
}
