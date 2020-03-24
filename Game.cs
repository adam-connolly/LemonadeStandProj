using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //member variables
        Player player;
        Store store;
        List<Day> days;
        int currentDay;
        //constructor
        public Game()
        {
            player = new Player();
            store = new Store();
            days = new List<Day>();
            currentDay = 1;
        }
        //member methods
        public void RunGame()
        {
            SetGameLength();
            
            store.SellLemons(player);
            store.SellIceCubes(player);
            store.SellSugarCubes(player);
            store.SellCups(player);
            player.SetRecipe();
            //GenerateCustomerList();
            player.MakePitcher();
            
            player.SellCupOfLemonade();
        }
        public void SetGameLength()
        {
            for (int i = 1; i <= 7; i++)
            {
                days.Add(new Day($"Day {i}"));                
            }
        }
    }
}
