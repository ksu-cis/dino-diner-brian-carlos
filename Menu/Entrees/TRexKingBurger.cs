using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        
        private bool wholeWheatBun = true;
        private bool steakburgerPattie = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onions = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (steakburgerPattie) ingredients.Add("Steakburger Pattie");
                if (steakburgerPattie) ingredients.Add("Steakburger Pattie");
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onions) ingredients.Add("Onions");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldOnions()
        {
            this.onions = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;

        }

        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}