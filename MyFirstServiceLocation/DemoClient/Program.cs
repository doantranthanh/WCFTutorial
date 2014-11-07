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
            localhost.MathServiceClient obj = new DemoClient.localhost.MathServiceClient();
            localhost.Math mathObj = new DemoClient.localhost.Math();

            mathObj.Number1 = 20;
            mathObj.Number2 = 10;

            Console.WriteLine("Addition continues...");
            Console.WriteLine(obj.Addition(mathObj));

            Console.WriteLine("Subtraction continues...");
            Console.WriteLine(obj.Subtraction(mathObj));

            Console.WriteLine("Multiplication continues...");
            Console.WriteLine(obj.Mutiplication(mathObj));

            Console.WriteLine("Division continues...");
            Console.WriteLine(obj.Division(mathObj));
        }
    }
}
