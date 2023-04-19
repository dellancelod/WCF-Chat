using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chat
{
    public class ServiceChat : IServiceChat
    {
        public int Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect(int id)
        {
            throw new NotImplementedException();
        }

        public void DoWork()
        {
        }

        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
