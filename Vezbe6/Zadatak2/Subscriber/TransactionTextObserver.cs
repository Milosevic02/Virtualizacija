using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak2.Publisher;

namespace Zadatak2.Subscriber
{
    public class TransactionTextObserver
    {
        public void HandleTransaction(object sender, PaymentEventArgs e)
        {
            Console.WriteLine($"You got one new message >> Message: {e.Message}, Ammount: {e.Amount}");
        }
    }
}
