using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelOfEfficiency
{
    public class EventMessageProtocol : EventArgs
    {
        public MessageType MessageType { get; set; }

        public string Message { get; set; }

        public EventMessageProtocol(MessageType type, string message)
        {
            MessageType = type;
            Message = message;
        }
    }
}
