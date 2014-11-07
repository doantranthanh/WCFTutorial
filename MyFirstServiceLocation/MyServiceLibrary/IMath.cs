using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace MyServiceLibrary
{
    [ServiceContract]
    public interface IMath
    {
        [OperationContract]
        int Addition(Math obj1);

        [OperationContract]
        int Subtraction(Math obj2);

        [OperationContract]
        int Mutiplication(Math obj3);

        [OperationContract]
        int Division(Math obj4);
    }
}
