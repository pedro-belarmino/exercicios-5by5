using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exNotificacoes
{
    public class Email : Notification
    {
        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("email enviado");
        }
    }
}
