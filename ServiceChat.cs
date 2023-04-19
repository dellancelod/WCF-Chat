using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF_Chat.Model;

namespace WCF_Chat
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)] //Singleton Service for every client
    public class ServiceChat : IServiceChat
    {
        internal List<User> Users { get; set; }

        public Guid Connect(string name)
        {
            User user = new User()
            {
                ID = Guid.NewGuid(),
                Name = name,
                Context = OperationContext.Current
            };

            SendMessage(user.Name + " connected to chat!");
            Users.Add(user);
            return user.ID;
        }

        public void Disconnect(int id)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
