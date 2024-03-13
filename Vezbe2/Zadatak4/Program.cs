using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100000;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    dictionary.Add(i, i * 4);
                }
                else
                    dictionary.Add(i, i * i);
            }

            Stopwatch stopwatch = new Stopwatch();

            int count = 1000000, key = 0, value = 0;

            stopwatch.Start();
            for (int i = 0; i < count; i++)
            {
                if (dictionary.ContainsKey(key))
                    value = dictionary[key];
            }
            stopwatch.Stop();
            Console.WriteLine("ContainsKey " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Restart();
            for (int i = 0; i < count; i++)
            {
                dictionary.TryGetValue(key, out value);
            }
            stopwatch.Stop();
            Console.WriteLine("TryGetValue " + stopwatch.Elapsed.TotalMilliseconds);

            Console.ReadKey();
        }
    }
}
