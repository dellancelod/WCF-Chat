using System;
using System.ServiceModel;

namespace WCF_Chat.Model
{
    internal class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public OperationContext Context { get; set; }

    }
}
