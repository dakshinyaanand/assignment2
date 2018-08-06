using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class UserTrail
    {
        int val1, val2;
        public void show()
        {
            Console.WriteLine("enter the value for val1 and val2");
            val1 = int.Parse(Console.ReadLine());
            val2 = int.Parse(Console.ReadLine());
            if (val2 < 0)
            {
                throw new Exceptionhandling();

            }else if (val1 < 0)
            {
                throw new Exceptionhandling();

            }
        }
        public void calculate()
        {
            if ((val1 - val2) < 0)
            {
                throw new Exceptionhandling();
            }
            else
            {
                Console.WriteLine("val1 -val2 is greater than zero");
            }
        }
       

    }
}
