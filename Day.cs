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

        //constructor
        public Day(string dayNumber)
        {
            weather = new Weather();
            customers = new List<Customer>();
            this.dayNumber = dayNumber;
        }
        //member methods
        public void GenerateCustomerList()
        {
            for (int i = 0; i < 100; i++)
            {
                customers.Add(new Customer($"Customer{i + 1}"));
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
                if (player.pitcher.cupsLeftInPitcher <= 0)
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
