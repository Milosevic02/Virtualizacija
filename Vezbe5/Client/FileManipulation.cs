using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    static class FileManipulation
    {
        public static void DownloadFiles(FileManipulationResults results)
        {
            var downloadPath = ConfigurationManager.AppSettings["downloadPath"];
            if(!Directory.Exists(downloadPath))
            {
                Directory.CreateDirectory(downloadPath);
            }
            foreach(KeyValuePair<string,MemoryStream> stream in results.MemoryStremCollection)
            {
                string fileName = stream.Key;
                using (FileStream fileStream = new FileStream($"{downloadPath}\\{fileName}", FileMode.Create, FileAccess.Write))
                {
                    stream.Value.WriteTo(fileStream);
                    fileStream.Dispose();
                    stream.Value.Dispose();
                    Console.WriteLine($"Downloaded file {stream.Key}");

                }
            }
        }
    }
}
