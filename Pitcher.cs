using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Pitcher : Item
    {
        //member variables
        public int cupsLeftInPitcher;
        

        //constructor
        public Pitcher()
        {
            name = "Pitcher";
            cupsLeftInPitcher = 20;
        }
        //member methods

    }
}
