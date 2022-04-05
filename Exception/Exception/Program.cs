using Exceptionn;
using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Email ilə mesaj göndərilməlidi.\n2-Sms ilə mesaj göndərilməlidi.\n0-Quit");
            int Choice = Int32.Parse(Console.ReadLine());
            EmailSender byemail = new EmailSender();
            SmsSender bysms = new SmsSender();
            switch (Choice)
            {
                case 1:byemail.SendMessage();
                    break;
                case 2:bysms.SendMessage();
                    break;
                case 3:Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }
    }
}
