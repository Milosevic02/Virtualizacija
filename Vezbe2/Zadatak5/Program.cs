﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>(count);

            for (int i = 0; i < 10; i++)
            {
                dictionary.Add(i, new List<string> { "Element 1" + i, "Element 2" + i, "Element 3" + i });
            }
            
            foreach(int key in dictionary.Keys)
            {
                for(int i = 0; i < dictionary[key].Count(); i++)
                {
                    Console.WriteLine($"<{key}> - <{i}> - <{dictionary[key][i]}>");
                }
            }
            Console.ReadLine();
        }
    }
}
