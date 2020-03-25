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
        double pricePreference;        
        public bool willBuyLemonade;
        

        //constructor
        public Customer(string name, Random lemonPref, Random sugarPref, Random pricePref)
        {
            this.name = name;
            lemonPreference = lemonPref.Next(2, 8);
            sugarPreference = sugarPref.Next(2, 8);           
            pricePreference = pricePref.Next(1, 10);
        }
        //member methods
        public bool BuyCupOfLemonade(Recipe recipe, Customer customer)
        {
            
            if (((customer.lemonPreference - 1) <= recipe.amountOfLemons  && (customer.lemonPreference + 1) >= recipe.amountOfLemons) && 
                ((customer.sugarPreference - 1) <= recipe.amountOfSugarCubes && (customer.sugarPreference + 1) >= recipe.amountOfSugarCubes) &&
                (customer.pricePreference <= recipe.pricePerCup))
            {
                Console.WriteLine($"{customer.name} bought a cup of Lemonade!");
                return willBuyLemonade = true;         
            }
            else
            {
                Console.WriteLine($"{customer.name} did not buy lemonade.");
                return willBuyLemonade = false;
            }
            
        }

    }
}
