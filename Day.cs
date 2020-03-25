using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //member variables
        public Weather weather;
        public List<Customer> customers;
        public string dayNumber;
        Random lemonPreference;
        Random sugarPreference;
        Random pricePreference;

        //constructor
        public Day(string dayNumber)
        {
            lemonPreference = new Random();
            sugarPreference = new Random();
            pricePreference = new Random();
            weather = new Weather();
            customers = new List<Customer>();
            this.dayNumber = dayNumber;
        }
        //member methods
        public void GenerateCustomerList()
        {
            for (int i = 0; i < 100; i++)
            {
                customers.Add(new Customer($"Customer{i + 1}", lemonPreference, sugarPreference, pricePreference));
            }
        }
        public void DisplayWeather()
        {
            weather.SetTemperature();
            weather.SetWeatherConditions();
        }
        public void RunDay(Store store, Player player)
        {
            DisplayWeather();
            store.DisplayPrices();
            Console.WriteLine($"Money: ${player.wallet.Money}");
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
            player.SetRecipe();
            GenerateCustomerList();
            player.MakePitcher();

            foreach(Customer customer in customers)
            {
                if (player.inventory.cups.Count <= 0 || player.inventory.iceCubes.Count <= 0 || player.inventory.lemons.Count <= 0 || player.inventory.sugarCubes.Count <= 0)
                {
                    Console.WriteLine("SOLD OUT");
                    break;
                }
                else if (player.pitcher.cupsLeftInPitcher <= 0)
                {
                     player.MakePitcher();
                     player.SellCupOfLemonade(customer.BuyCupOfLemonade(player.recipe, customer));
                }
                else
                {
                     player.SellCupOfLemonade(customer.BuyCupOfLemonade(player.recipe, customer));
                }

            }           
        }
    }
}
