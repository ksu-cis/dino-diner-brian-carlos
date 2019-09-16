using System.Collections.Generic;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        
        private bool flourTortilla = true;
        private bool chickenBreast = true;
        private bool romaineLettuce = true;
        private bool ceasarDressing = true;
        private bool parmesanCheese = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla" };
                if (chickenBreast) ingredients.Add("Chicken Breast");
                if (romaineLettuce) ingredients.Add("Romaine Lettuce");
                if (ceasarDressing) ingredients.Add("Ceasar Dressing");
                if (parmesanCheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        public VelociWrap(){
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldCheese()
        {
            this.parmesanCheese = false;
        }

        public void HoldDressing()
        {
            this.ceasarDressing = false;
        }

        public void HoldLettuce()
        {
            this.romaineLettuce = false;
        }
    }
}
