using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace StaffClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StaffServiceClient sv = new StaffServiceClient())
            {
                sv.CreateListStaff();
                Console.WriteLine(sv.DisplayStaff());
                Console.WriteLine(sv.GetBirthday(1).ToShortDateString());
                Console.WriteLine(sv.GetBirthday(2).ToShortDateString());
                Console.WriteLine(sv.GetBirthday(3).ToShortDateString());

                Console.ReadLine();
            }
        }
    }
}
