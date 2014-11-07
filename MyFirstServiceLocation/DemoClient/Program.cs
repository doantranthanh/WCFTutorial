using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.MathServiceClient obj = new localhost.MathServiceClient();
            localhost.Math mathObj = new localhost.Math
                                     {
                                         Number1 = 20,
                                         Number2 = 10
                                     };

            Console.WriteLine("Addition continues...");
            Console.WriteLine(obj.Addition(mathObj));

            Console.WriteLine("Subtraction continues...");
            Console.WriteLine(obj.Subtraction(mathObj));

            Console.WriteLine("Multiplication continues...");
            Console.WriteLine(obj.Mutiplication(mathObj));

            Console.WriteLine("Division continues...");
            Console.WriteLine(obj.Division(mathObj));

            Console.WriteLine("Press to continues...");

            Console.ReadLine();
        }
    }
}
