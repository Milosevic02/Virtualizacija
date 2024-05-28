using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static void PrintAllBooks(ILibrary proxy)
        {
            Console.WriteLine("<Press any key for book overview>");
            Console.ReadKey();

            Console.WriteLine("Book Overview:");
            foreach (Book book in proxy.GetAllBooks())
            {
                Console.WriteLine($"Title: {book.Title}  score: {book.Score}");
            }
            Console.WriteLine();
        }
    }
}
