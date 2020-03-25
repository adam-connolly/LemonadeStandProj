using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public string name;
        public Recipe recipe;
        public Pitcher pitcher;

        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
        }

        // member methods (CAN DO)
        public void SetRecipe()
        {
            recipe = new Recipe();
            recipe.DisplayRecipe();
            Console.WriteLine("Would you like to change your recipe? Press number associated with Yes/No\n" +
                "1. Yes\n" +
                "2. No");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    recipe.ChangeRecipe();
                    break;
                default:
                    break;
            }

        }
        public void MakePitcher()
        {
            if (inventory.lemons.Count >= recipe.amountOfLemons && inventory.sugarCubes.Count >= recipe.amountOfSugarCubes && inventory.cups.Count > 0)
            {
                pitcher = new Pitcher();
                inventory.RemoveLemonsFromInventory(recipe.amountOfLemons);
                inventory.RemoveSugarCubesFromInventory(recipe.amountOfSugarCubes);                
            }
            else
            {
                Console.WriteLine("Don't have enough supplies to make more lemonade!");
            }
            
        }        
        public void SellCupOfLemonade(bool custDecision)
        {
            if (pitcher.cupsLeftInPitcher > 0)
            {
                if (custDecision == true)
                {
                    inventory.RemoveCupsFromInventory(1);
                    inventory.RemoveIceCubesFromInventory(recipe.amountOfIceCubes);
                    wallet.GetMoneyFromSale(recipe.pricePerCup);                    
                    pitcher.cupsLeftInPitcher--;
                }
                
            }            
        }        
    }
}
