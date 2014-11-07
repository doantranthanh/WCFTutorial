using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IMathService
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

[DataContract]

public class Math
{

    int number1, number2;

    [DataMember]

    public int Number1
    {

        get { return number1; }

        set { number1 = value; }

    }

    [DataMember]

    public int Number2
    {

        get { return number2; }

        set { number2 = value; }

    }

}
