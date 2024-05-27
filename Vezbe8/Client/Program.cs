using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IFileHandler> factory = new ChannelFactory<IFileHandler>("FileHandlingService");
            IFileHandler proxy = factory.CreateChannel();

            var downloadPath = ConfigurationManager.AppSettings["downloadPath"];
            if(!Directory.Exists(downloadPath))
            {
                Directory.CreateDirectory(downloadPath);
            }

            FileManipulation fileManipulation = new FileManipulation(downloadPath);

            ReceiveFileOption(proxy, fileManipulation);

            Console.ReadKey();
        }

        static void ReceiveFileOption(IFileHandler proxy, FileManipulation fileManipulation)
        {
            Console.WriteLine("Please input key word for file");
            string fileName = Console.ReadLine();
            FileManipulationResults result = proxy.GetFile(new FileManipulationOptions(fileName));

            switch(result.ResultType)
            {
                case ResultTypes.Success:
                    fileManipulation.DownloadFile(result, fileName);
                    break;
                case ResultTypes.Warning:
                    Console.WriteLine($"[WARNING] Receive Files return message:{result.ResultMessage}");
                    break;
                case ResultTypes.Failed:
                    Console.WriteLine($"[ERROR] Receive Files return message:{result.ResultMessage}");
                    break;
            }
        }

    }
}
