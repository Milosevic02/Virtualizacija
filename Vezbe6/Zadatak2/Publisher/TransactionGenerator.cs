using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2.Publisher
{
    public class TransactionGenerator
    {
        public delegate void TransactionEventHandler(object sender,PaymentEventArgs e);

        public event TransactionEventHandler PaymentReceivedEvent;
        public event TransactionEventHandler PaymentMadeEvent;

        public void PerformTransaction(int amount)
        {
            if (amount > 0)
            {
                ReceivePayment(amount);
            }
            else if (amount < 0)
            {
                MakePayment(amount);
            }
        }


        private void ReceivePayment(int amount)
        {
            if(PaymentReceivedEvent != null)
            {
                PaymentReceivedEvent(this,new PaymentEventArgs(amount,"Increase"));
            }
            else
            {
                Console.WriteLine("No subscribers!");
            }
        }

        private void MakePayment(int amount)
        {
            if (PaymentMadeEvent != null)
            {
                PaymentMadeEvent(this, new PaymentEventArgs(amount, "Decrease"));
            }
            else
            {
                Console.WriteLine("No subscribers!");
            }
        }
    }
}
