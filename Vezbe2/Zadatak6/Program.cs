using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<string>> dictionary1 = new Dictionary<int, List<string>>();
            Dictionary<int, List<string>> dictionary2 = new Dictionary<int, List<string>>();

            for (int i = 0; i < 10; i++)
            {
                dictionary1.Add(i, new List<string> { "Element 1" + i, "Element 2" + i, "Element 3" + i });
            }

            for (int i = 0; i < 20; i++)
            {
                dictionary2.Add(i, new List<string> { "Element 1" + i, "Element 2" + i, "Element 3" + i, "Element 4" + i, "Element 5" + i });
            }

            Dictionary<int, List<string>> unija = new Dictionary<int, List<string>>(dictionary1);

            foreach (KeyValuePair<int, List<string>> pair in dictionary2)
            {

                if(unija.TryGetValue(pair.Key, out List<string> list))
                {
                    for (int i = 0;i < pair.Value.Count;i++)
                    {
                        list.Add(pair.Value[i]);
                    }
                }
                else
                {
                    unija.Add(pair.Key, pair.Value);
                }
            }

            foreach (KeyValuePair<int, List<string>> pair in unija)
            {
                for (int i = 0; i < pair.Value.Count; i++)
                {
                    Console.WriteLine($"<{pair.Key}>  <{pair.Value[i]}>");
                }
            }
            Console.ReadLine();
        }
    }
}
