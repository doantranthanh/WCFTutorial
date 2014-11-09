using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StaffService
{ 
    [ServiceContract]
    public interface IStaffService
    {
        [OperationContract]
        void CreateListStaff();

        [OperationContract]
        string DisplayStaff();

        [OperationContract]
        DateTime GetBirthday(int staffID);

        [OperationContract]
        string GetStaffName(int staffID);

    }

}
