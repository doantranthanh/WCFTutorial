using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StaffService
{
    public class StaffService : IStaffService
    {
        public List<Staff> ListStaff = new List<Staff>(); 

        public string DisplayStaff()
        {
            return ListStaff.Aggregate(string.Empty, (current, staff) => current + String.Format("{0} - {1} - {2}\n", staff.StaffID, staff.Name, staff.Birthday.ToShortDateString()));
        }

        public DateTime GetBirthday(int staffID)
        {
            var query = ListStaff.Where(x => x.StaffID == staffID).Select(x => x.Birthday);

            return query.FirstOrDefault();
        }


        public string GetStaffName(int staffID)
        {
            var query = ListStaff.Where(x => x.StaffID == staffID).Select(x => x.Name);

            return query.FirstOrDefault();
        }

        public void CreateListStaff()
        {
            Staff staff1 = new Staff
                            {
                                StaffID = 1,
                                Name = "David",
                                Birthday = new DateTime(1984, 07, 25)
                            };

            Staff staff2 = new Staff
                            {
                                StaffID = 2,
                                Name = "Peter",
                                Birthday = new DateTime(1984, 08, 25)
                            };

            Staff staff3 = new Staff
                            {
                                StaffID = 3,
                                Name = "Dave",
                                Birthday = new DateTime(1984, 09, 25)
                            };

            ListStaff.Add(staff1);
            ListStaff.Add(staff2);
            ListStaff.Add(staff3);
        }
    }
}
