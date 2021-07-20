using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_App
{
    public class TextMessage
    { 
        protected string sender;
        protected string recipient;
        protected string textContent;
        protected bool gourpMessage;
        protected string statusRecieved;

        public string Sender { get => sender; set => sender = value; }
        public string Recipient { get => recipient; set => recipient = value; }
        public string TextContent { get => textContent; set => textContent = value; }
        public bool GroupMessage { get => gourpMessage; set => gourpMessage = value; }
        public string StatusRecieved { get => statusRecieved; set => statusRecieved = value; }
    }
}
