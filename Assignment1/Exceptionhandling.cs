using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Exceptionhandling:Exception
    {
        string msg;
        public Exceptionhandling()
        {
            msg = "Number is less than zero";
        }
        public Exceptionhandling(string msg)
        {
            this.msg = msg;
        }
        public override string Message
        {
            get
            {
                return msg;
            }
        }
    }
}
