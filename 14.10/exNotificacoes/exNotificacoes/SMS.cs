using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exNotificacoes
{
    internal class SMS : Notification
    {
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("SMS: " + message);
        }
    }
}
