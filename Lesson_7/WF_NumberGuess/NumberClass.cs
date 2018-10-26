using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_NumberGuess
{
    class NumberClass
    {
        int number;

        public NumberClass (int min, int max)
        {
            GetNewNumber(min, max);
        }

        public void GetNewNumber(int min, int max)
        {
            Random rnd = new Random();
            number = rnd.Next(min, max + 1);
        }

        public int Number
        {
            get
            {
                return number;
            }
        }

    }
}
