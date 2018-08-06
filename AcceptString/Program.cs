using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptString
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AcceptString a = new AcceptString();
                a.inputString();
            }
            catch (NoMatchException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
