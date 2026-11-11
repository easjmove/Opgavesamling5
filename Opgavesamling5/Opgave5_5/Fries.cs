using Opgave5_5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave5_5
{
    public class Fries
    {
        public FriesSize Size { get; set; }
        public double Price { get; set; }

        public Fries(FriesSize size)
        {
            Size = size;
            Price = size switch
            {
                FriesSize.Medium => 24.0,
                FriesSize.Large => 33.0,
                FriesSize.XLarge => 50.0,
                _ => 0.0
            };
        }

        public override string ToString()
        {
            return $"{Size} Pomfritter ({Price} kr.)";
        }
    }
}
