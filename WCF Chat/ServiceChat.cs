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

        public void Disconnect(Guid id)
        {
            var user = Users.FirstOrDefault(i => i.ID == id);

            if (user != null)
            {
                Users.Remove(user);
                SendMessage(user.Name + " disconnected!");
            }
        }

        public void SendMessage(string message)
        {
            foreach (var item in Users)
            {
                string answer = DateTime.Now.ToShortTimeString();

                answer += message;

                item.Context.GetCallbackChannel<IServerChatCallback>().MessageCallback(answer);
            }
        }

        public void SendMessage(string message, Guid id)
        {
            foreach (var item in Users)
            {
                string answer = DateTime.Now.ToShortTimeString();
                var user = Users.FirstOrDefault(i => i.ID == id);

                if (user != null)
                {
                    answer += ": " + user.Name + " ";
                }

                answer += message;

                item.Context.GetCallbackChannel<IServerChatCallback>().MessageCallback(answer);
            }
        }
    }
}
