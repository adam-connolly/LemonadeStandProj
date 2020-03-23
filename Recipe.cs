using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe : Item
    {
        //member variables
        public int amountOfSugarCubes;
        public int amountOfLemons;
        public int amountOfIceCubes;
        public double pricePerCup;
        //constructor
        public Recipe()
        {
            amountOfLemons = 4;
            amountOfSugarCubes = 4;
            amountOfIceCubes = 4;
        }
        public int AddLemonsToRecipe()
        {
            Console.WriteLine("How many lemons per pitcher?");
            int lemonsPerPitcher = Convert.ToInt32(Console.ReadLine());
            return lemonsPerPitcher;
        }
        public int AddSugarCubesToRecipe()
        {
            Console.WriteLine("How many sugar cubes per pitcher?");
            int sugarCubesPerPitcher = Convert.ToInt32(Console.ReadLine());
            return sugarCubesPerPitcher;
        }
        public int AddIceCubesToCup()
        {
            Console.WriteLine("How many ice cubs per cup?");
            int iceCubesPerCup = Convert.ToInt32(Console.ReadLine());
            return iceCubesPerCup;
        }
    }
}
