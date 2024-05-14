using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2.Publisher
{
    public class PaymentEventArgs : EventArgs
    {
        public int Amount { get; }
        public string Message { get; }

        public PaymentEventArgs(int amount, string message)
        {
            Message = message;
            Amount = amount;
        }
    }
}
