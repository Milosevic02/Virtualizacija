using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static int PrintMenu()
        {
            Console.WriteLine("Select an option");
            Console.WriteLine("1. Add book recommendation");
            Console.WriteLine("2. Exit and provide content for recommendations");
            if (Int32.TryParse(Console.ReadLine(), out int number))
            {
                if (number >= 1 && number <= 2)
                {
                    return number;
                }
            }
            return 0;
        }
    }
}
