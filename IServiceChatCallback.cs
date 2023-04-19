using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Clientside Interface for receiving messages
*/
namespace WCF_Chat
{
    internal interface IServiceChatCallback
    {
        void MessageCallback(string message);
    }
}
