using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak2.Publisher;

namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
        }

        static void RegulatePayment(TransactionGenerator transaction)
        {
            while (true)
            {
                Console.WriteLine("Enter transaction amount (or 'END' to exit):");
                string input = Console.ReadLine();

                if (input.ToUpper() == "END")
                {
                    break;
                }

                if (!int.TryParse(input, out int amount))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                transaction.PerformTransaction(amount);
            }

        }


        static string SubscribtionMenu()
        {
            Console.WriteLine("1. Subscribe to text messages");
            Console.WriteLine("2. Subscribe to email messages");
            return Console.ReadLine();
        }
    }
}
