using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {

        private bool chickenNugget = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget" };
                if (chickenNugget) ingredients.Add("Chicken Nugget");
                if (chickenNugget) ingredients.Add("Chicken Nugget");
                if (chickenNugget) ingredients.Add("Chicken Nugget");
                if (chickenNugget) ingredients.Add("Chicken Nugget");
                if (chickenNugget) ingredients.Add("Chicken Nugget");
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            this.chickenNugget = true;
            this.Price += .25;
        }
    }
}
