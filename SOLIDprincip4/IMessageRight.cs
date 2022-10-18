using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprincip4
{
    interface IMessageRight
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
    interface IVoiceMessage : IMessageRight
    {
        byte[] Voice { get; set; }
    }
    interface ITextMessage : IMessageRight
    {
        string Text { get; set; }
    }

    interface IEmailMessage : IMessageRight
    {
        string Subject { get; set; }
    }
}
