using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatServerLibrary
{
    [ServiceContract]
    public interface IChatService
    {
        [OperationContract]
        void PostNote(string from, string note);
    }
}
