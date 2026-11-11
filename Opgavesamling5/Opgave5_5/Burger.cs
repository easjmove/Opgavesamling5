using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave5_5
{
    public class Burger
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Burger(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} ({Price} kr.)";
        }
    }
}
