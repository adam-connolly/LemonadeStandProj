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
            pricePerCup = 0.25;
        }
        public void DisplayRecipe()
        {
            Console.WriteLine($"Lemons per pitcher: {amountOfLemons}\n" +
                $"Sugar cubes per pitcher: {amountOfSugarCubes}\n" +
                $"Ice cubes per cup: {amountOfIceCubes}\n" +
                $"Price per cup: {pricePerCup}");
        }
        public void ChangeRecipe()
        {
            AddLemonsToRecipe();
            AddSugarCubesToRecipe();
            AddIceCubesToCup();
            ChangePricePerCup();
        }
        public int AddLemonsToRecipe()
        {
            Console.WriteLine($"Current Lemons: {amountOfLemons} per pitcher");
            Console.WriteLine("How many lemons do you want in each pitcher?");
            amountOfLemons = Convert.ToInt32(Console.ReadLine());
            return amountOfLemons;
        }
        public int AddSugarCubesToRecipe()
        {
            Console.WriteLine($"Current Sugar Cubes: {amountOfSugarCubes} per pitcher");
            Console.WriteLine("How many sugar cubes do you want in each pitcher?");
            amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
            return amountOfSugarCubes;
        }
        public int AddIceCubesToCup()
        {
            Console.WriteLine($"Current Ice Cubes: {amountOfIceCubes} per cup");
            Console.WriteLine("How many ice cubs do you want in each cup?");
            amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
            return amountOfIceCubes;
        }
        public double ChangePricePerCup()
        {
            Console.WriteLine($"Current price: {pricePerCup}");
            Console.WriteLine("What do you want to change the price to?");
            pricePerCup = Convert.ToDouble(Console.ReadLine());
            return pricePerCup;
        }
    }
}
