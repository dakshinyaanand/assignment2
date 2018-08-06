using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UserTrail u = new UserTrail();
                u.show();
                u.calculate();
            }
            catch(Exceptionhandling ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
