using System;
using System.ServiceModel;

namespace StaffServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(StaffService.StaffService)))
            {
                sh.Open();
                Console.WriteLine("Staff Service opened successfully");
                Console.WriteLine("Press Enter to terminate Staff Service");
                Console.ReadKey();
            }
        }
    }
}
