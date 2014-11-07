using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyServiceLibrary
{
    public class MyService: IMath
    {
        public int Addition(Math obj1)
        {
            return (obj1.Number1 + obj1.Number2);
        }

        public int Subtraction(Math obj2)
        {
            try
            {
                return (obj2.Number1 - obj2.Number2);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Mutiplication(Math obj3)
        {
            return obj3.Number1*obj3.Number2;
        }

        public int Division(Math obj4)
        {
            if (obj4.Number2 != 0)
            {
                return obj4.Number1/obj4.Number2;
            }
            else
            {
                return 0;
            }
        }
    }
}
