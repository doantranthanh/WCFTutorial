using System;
using System.ServiceModel;
using ChatServerLibrary;

namespace ChatHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof (ChatService)))
            {
                host.Open();

                Console.WriteLine("Service Ready");
                Console.ReadKey();
            }
        }
    }
}
