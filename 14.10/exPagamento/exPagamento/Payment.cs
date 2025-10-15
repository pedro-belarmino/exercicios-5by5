using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exPagamento
{
    internal abstract class Payment
    {
        private decimal Value {  get; set; }
        private DateTime PaymentDate { get; set; }

        public abstract void PaymentProcess(DateTime dt, decimal value);

        public void setPaymentDate(DateTime dt)
        {
            PaymentDate = dt;
        }
        public void setValue(decimal value)
        {
            Value = value;
        }
    }
}
