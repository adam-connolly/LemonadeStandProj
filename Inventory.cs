using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        // constructor (SPAWNER)
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }

        // member methods (CAN DO)
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
        public void RemoveLemonsFromInventory(int numberOfLemons)
        {
            if (numberOfLemons <= lemons.Count)
            {
                for (int i = 0; i < numberOfLemons; i++)
                {
                    lemons.Remove(lemons[0]);
                }
            }
            else
            {
                Console.WriteLine("Don't have enough lemons to make more lemonade!");                
            }
        }

        public void RemoveSugarCubesFromInventory(int numberOfSugarCubes)
        {
            if (numberOfSugarCubes <= sugarCubes.Count)
            {
                for (int i = 0; i < numberOfSugarCubes; i++)
                {
                    sugarCubes.Remove(sugarCubes[0]);
                }
            }
            else
            {
                Console.WriteLine("Don't have enough sugar to make more lemonade!");
            }
        }

        public void RemoveIceCubesFromInventory(int numberOfIceCubes)
        {
            if (numberOfIceCubes <= iceCubes.Count)
            {
                for (int i = 0; i < numberOfIceCubes; i++)
                {
                    iceCubes.Remove(iceCubes[0]);
                }
            }
            else
            {
                Console.WriteLine("Don't have enough ice to make more lemonade!");
            }
        }

        public void RemoveCupsFromInventory(int numberOfCups)
        {
            if (numberOfCups <= cups.Count)
            {
                for (int i = 0; i < numberOfCups; i++)
                {
                    cups.Remove(cups[0]);
                }
            }
            else
            {
                Console.WriteLine("Don't have enough cups to serve more lemonade!");
            }
        }
        public void DisplayInventory()
        {
            Console.WriteLine($"Your Stock:\n" +
                $"Lemons: {lemons.Count}\n" +
                $"Sugar Cubes: {sugarCubes.Count}\n" +
                $"Ice Cubes: {iceCubes.Count}\n" +
                $"Cups: {cups.Count}\n");
        }
    }
}
