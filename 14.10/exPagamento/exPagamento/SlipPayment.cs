using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exPagamento
{
    internal class SlipPayment : Payment
    {
        public override void PaymentProcess(DateTime dt, decimal value)
        {
            this.setValue(value);
            this.setPaymentDate(dt);
            Console.WriteLine($"foi -> {value}");
        }
    }
}
