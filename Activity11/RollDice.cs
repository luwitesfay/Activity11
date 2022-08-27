using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11
{
    public class RollDice
    {
        //rivate field for the number of sides of the dice
        private int numSides;


        public RollDice(int numSides)
        {

            //Get the sides
            this.numSides = numSides;
        }

        //Method to roll a dice
        public int rollDie()
        {
            //Random number to rall
            Random random = new Random();
            return random.Next(1, numSides + 1);
        }

    }
}
