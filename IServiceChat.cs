using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chat
{
    [ServiceContract(CallbackContract = typeof(IServerChatCallback))]
    public interface IServiceChat
    {
        [OperationContract]
        Guid Connect(string name);

        [OperationContract]
        void Disconnect(Guid id);

        [OperationContract(IsOneWay = true)] //We do not expect response from Server
        void SendMessage(string message);


    }
}
