using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chat
{
    [ServiceContract]
    public interface IServiceChat
    {
        [OperationContract]
        int Connect();

        [OperationContract]
        void Disconnect(int id);

        [OperationContract(IsOneWay = true)] //We do not expect response from Server
        void SendMessage(string message);

    }
}
