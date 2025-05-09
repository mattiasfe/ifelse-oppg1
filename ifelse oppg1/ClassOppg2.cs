using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_oppg1
{
    internal class ClassOppg2
    {
        int number = 8;
        int number2 = 8;
        bool ikkeLike = false;

        public void Run()
        {

            if (number == number2)
            {
                ikkeLike = true;
            }
            else
            {
                ikkeLike = false;
            }

            if (ikkeLike == true)
            {
               Console.WriteLine($"{number + number2}"); 
            }
            else if (ikkeLike == false)
            {
               Console.WriteLine($"{number - number2}");
            }

        }

    }
}
