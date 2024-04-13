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


        static void ReceiveFilesOption(IFileHandling proxy)
        {
            Console.WriteLine("Please input key word for files");
            string keyWord = Console.ReadLine();
            FileManipulationResults results =
            proxy.GetFiles(new FileManipulationOptions(keyWord));

            switch (results.ResultType)
            {
                case ResultTypes.Success:
                    FileManipulation.DownloadFiles(results);
                    break;
                case ResultTypes.Warning:
                    Console.WriteLine($"[WARNING] Receive Files return message:{results.ResultMessage}");
                    break;
                case ResultTypes.Failed:
                    Console.WriteLine($"[ERROR] Receive Files return message:{results.ResultMessage}");
                    break;
            }

            static void SendFileOption(IFileHandling proxy)
            {
                Console.WriteLine("Please input file that you want to sent");
                string fileName = Console.ReadLine();
                FileManipulationResults results =
                    proxy.SendFile(new FileManipulationOptions(FileManipulation.GetMemoryStream(fileName), fileName));

                switch (results.ResultType)
                {
                    case ResultTypes.Success:
                        Console.WriteLine("File is sucessfuly sent.");
                        break;
                    case ResultTypes.Warning:
                        Console.WriteLine($"[WARNING] Send File return message:{results.ResultMessage}");
                        break;
                    case ResultTypes.Failed:
                        Console.WriteLine($"[ERROR] Send File return message:{results.ResultMessage}");
                        break;
                }
            }
        }
    }
}
