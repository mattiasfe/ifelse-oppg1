using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_oppg1
{
    internal class ClassOppg1
    {
        int number = 14;
        int otherNumber = 16;
        bool isequal = false;

        public void Run()
        {
            if(number == otherNumber)
            {
                isequal = true;
                Console.WriteLine("the numbers is eaqual");
            }
            else
            {
                Console.WriteLine("the numbers are not equal");
            }
        }

    }
}
