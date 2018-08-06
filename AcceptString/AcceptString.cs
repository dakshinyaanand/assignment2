using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptString
{
    class AcceptString
    {
        public void inputString()
        {
            Console.WriteLine("enter the sting");
            string st = Console.ReadLine();
            string sr = "Deloitte Training";
           int result= string.Compare(st,sr);
            if (result != 0)
            {
                throw new NoMatchException();
            }
            else
            {
                Console.WriteLine("string matches");
            }
        }
    }
}
