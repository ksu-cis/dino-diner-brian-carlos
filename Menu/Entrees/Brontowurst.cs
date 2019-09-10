﻿using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {

        private bool brautwurst = true;
        private bool wholeWheatBun = true;
        private bool peppers = true;
        private bool onions = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onions");
                return ingredients;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnions()
        {
            this.onions = false;
        }
    }
}
