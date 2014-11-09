using System;
using System.ServiceModel;
using StaffService;

namespace StaffServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(Staff)))
            {
                sh.Open();
                Console.WriteLine("Staff Service opened successfully");
                Console.WriteLine("Press Enter to terminate Staff Service");
                Console.ReadLine();
            }
        }
    }
}
