using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprincip4
{
    class EmailMessage : IMessage
    {
        public string Subject { get; set; } = "";
        public string Text { get; set; } = "";
        public string FromAddress { get; set; } = "";
        public string ToAddress { get; set; } = "";

        public void Send() => Console.WriteLine($"Отправляем Email-сообщение: {Text}");
    }

    class SmsMessage : IMessage
    {
        public string Text { get; set; } = "";
        public string FromAddress { get; set; } = "";
        public string ToAddress { get; set; } = "";

        public string Subject
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Send() => Console.WriteLine($"Отправляем Sms-сообщение: {Text}");
    }

    class VoiceMessage : IMessage
    {
        public string ToAddress { get; set; } = "";
        public string FromAddress { get; set; } = "";
        public byte[] Voice { get; set; } = new byte[] { };

        public string Text
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Subject
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Send() => Console.WriteLine("Передача голосовой почты");
    }
}
