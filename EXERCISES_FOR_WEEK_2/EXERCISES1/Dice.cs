using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tran Dinh Khanh _ 20IT271
namespace EXERCISES1
{
    class Dice
    {
        private int numberOfSides;

        public Dice(int sides)
        {
            numberOfSides = sides;
        }

        public int Roll()
        {
            Random random = new Random();
            return random.Next(1, numberOfSides + 1);
        }

    }
}
