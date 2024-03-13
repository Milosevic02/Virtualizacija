using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Zadatak1

            int n = 154357;
            List<int> list = new List<int>(n);
            int sum = 0;
            for (int i = 0; i < n; i++) { 
                if(i%4 == 0)
                {
                    list.Add(i);
                }
                else
                {
                    list.Add(-i);
                }

            }
            foreach (int i in list)
            {
                if(i%17 == 0) {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of all numbers in the list whose indices are divisible by 17: " + sum);

            #endregion

            #region Zadatak2

            HashSet<int> set = new HashSet<int>(list);

            #endregion

            #region Zadatak3

            int count = 100000;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < count; i++)
            {
                list.Contains(-100001);
            }
            stopwatch.Stop();
            Console.WriteLine("List " + stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Restart();
            for (int i = 0; i < count; i++)
            {
                set.Contains(-100001);
            }
            stopwatch.Stop();
            Console.WriteLine("HashSet " + stopwatch.Elapsed.TotalMilliseconds);

            #endregion

            Console.ReadLine();
        }
    }
}
