using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using StaffClient.ServiceReference1;

namespace StaffClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StaffServiceClient sh = new StaffServiceClient())
            {
                sh.Open();
                sh.CreateListStaff();
                Console.WriteLine(sh.DisplayStaff());
                Console.WriteLine(sh.GetBirthday(1).ToShortDateString());
                Console.WriteLine(sh.GetBirthday(2).ToShortDateString());
                Console.WriteLine(sh.GetBirthday(3).ToShortDateString());

                Console.ReadKey();
            }
        }
    }
}
