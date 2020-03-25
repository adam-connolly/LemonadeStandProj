using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //member variables
        List<string> names;
        public string name;
        int lemonPreference;
        int sugarPreference;
        Recipe recipe;
        Player player;
        public bool willBuyLemonade;

        //constructor
        public Customer(string name)
        {
            this.name = name;
            Random lemonPref = new Random();
            lemonPreference = lemonPref.Next(3, 8);
            Random sugarPref = new Random();
            sugarPreference = sugarPref.Next(3, 8);
        }
        //member methods
        public bool BuyCupOfLemonade()
        {            
            if ((recipe.amountOfLemons >= lemonPreference - 1 && recipe.amountOfLemons <= lemonPreference +1) && (recipe.amountOfSugarCubes >= sugarPreference - 1 && recipe.amountOfSugarCubes <= sugarPreference + 1))
            {              
                return willBuyLemonade = true;         
            }
            return willBuyLemonade = false;
        }

    }
}
