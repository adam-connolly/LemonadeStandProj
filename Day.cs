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
        public void GenerateCustomerList(string weather, int temperature)
        {
            if (weather == "Mostly Sunny")
            {
                for (int i = 0; i < 100; i++)
                {
                    customers.Add(new Customer($"Customer{i + 1}", lemonPreference, sugarPreference, pricePreference));
                }
            }
            else if (weather == "Sunny and Clear")
            {
                for (int i = 0; i < 150; i++)
                {
                    customers.Add(new Customer($"Customer{i + 1}", lemonPreference, sugarPreference, pricePreference));
                }
            }
            else if (weather == "Overcast")
            {
                for (int i = 0; i < 80; i++)
                {
                    customers.Add(new Customer($"Customer{i + 1}", lemonPreference, sugarPreference, pricePreference));
                }
            }
            else if (weather == "Rain")
            {
                for (int i = 0; i < 40; i++)
                {
                    customers.Add(new Customer($"Customer{i + 1}", lemonPreference, sugarPreference, pricePreference));
                }
            }            
        }
        public void DisplayWeather()
        {
            weather.SetTemperature();
            weather.SetWeatherConditions();
            Console.WriteLine("\n");
        }
        public void RunDay(Store store, Player player)
        {
            DisplayWeather();
            store.DisplayPrices();
            Console.WriteLine($"Money: ${player.wallet.Money}\n");
            player.inventory.DisplayInventory();
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
            player.SetRecipe();
            GenerateCustomerList(weather.condition, weather.temperature);
            player.MakePitcher();
            ServeCustomers(player, weather);
            player.inventory.RemoveIceCubesFromInventory(player.inventory.iceCubes.Count);
            player.inventory.DisplayInventory();
        }
        public void ServeCustomers(Player player, Weather weather)
        {
            foreach (Customer customer in customers)
            {
                if (player.inventory.cups.Count <= 0 || player.inventory.iceCubes.Count <= 0 || player.inventory.lemons.Count <= 0 || player.inventory.sugarCubes.Count <= 0)
                {
                    Console.WriteLine("SOLD OUT");
                    break;
                }
                else if (player.pitcher.cupsLeftInPitcher <= 0)
                {
                    if (player.inventory.iceCubes.Count <= player.recipe.amountOfIceCubes || player.inventory.lemons.Count <= player.recipe.amountOfLemons || player.inventory.sugarCubes.Count <= player.recipe.amountOfSugarCubes)
                    {
                        Console.WriteLine("Don't have enough supplies to make more lemonade!");
                        break;
                    }
                    else
                    {
                        player.MakePitcher();
                        player.SellCupOfLemonade(customer.BuyCupOfLemonade(player.recipe, customer, weather));
                    }                    
                }
                else
                {
                    player.SellCupOfLemonade(customer.BuyCupOfLemonade(player.recipe, customer, weather));
                }
            }
        }
    }
}
