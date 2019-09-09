using System;

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
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59;
        }

        public void AddNugget()
        {
            Ingredients
        }
    }
}
