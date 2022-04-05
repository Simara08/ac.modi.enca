using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionn
{
    public abstract class MessageSender
    {
        public abstract void SendMessage();
       
    }
    public  class EmailSender : MessageSender
    {
        public  override void SendMessage()
        {
            Console.WriteLine("Send message via email");
        }
    }
    public class SmsSender : MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("Send message via sms");
        }
    }
}
