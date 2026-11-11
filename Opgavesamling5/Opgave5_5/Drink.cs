using System;

namespace Opgave5_5
{
    public class Drink
    {
        public string Name { get; set; }
        public DrinkSize Size { get; set; }
        public double Price { get; set; }

        public Drink(string name, DrinkSize size)
        {
            Name = name;
            Size = size;
            Price = size switch
            {
                DrinkSize.Small => 13.0,
                DrinkSize.Medium => 25.0,
                DrinkSize.Large => 35.0,
                _ => 0.0
            };
        }

        public override string ToString()
        {
            return $"{Size} {Name} ({Price} kr.)";
        }
    }
}