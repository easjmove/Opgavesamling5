using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave5_5
{
    public class Menu
    {
        public Drink SelectedDrink { get; set; }
        public Fries SelectedFries { get; set; }
        public Burger SelectedBurger { get; set; }

        public Menu(Drink drink, Fries fries, Burger burger)
        {
            SelectedDrink = drink;
            SelectedFries = fries;
            SelectedBurger = burger;
        }

        public double GetTotalPrice()
        {
            return SelectedDrink.Price + SelectedFries.Price + SelectedBurger.Price;
        }

        public override string ToString()
        {
            return $"\n  - Drikkevare: {SelectedDrink}\n  - Pomfritter: {SelectedFries}\n  - Burger: {SelectedBurger}";
        }
    }
}
