using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace UploadClient
{
    public class BookRecommendation
    {
        private FileSystemWatcher fileWatcher;
        private readonly ILibrary proxy;

        public BookRecommendation(string path,ILibrary sender)
        {
            CreateFileSystemWatcher(path);
            this.proxy = sender;
        }



        private void SendFile(string filePath,string fileName)
        {
            try
            {
                proxy.AddBookRecommendation(new FileManipulationOptions(GetMemoryStream(filePath), fileName));
                Console.WriteLine($"Recommendation for {filePath} modified at {DateTime.Now}");

            }
            catch (FaultException<CustomException> ex)
            {
                Console.WriteLine($"ERROR : {ex.Detail.Message}");
            }
        }


        public static MemoryStream GetMemoryStream(string path)
        {
            if(!File.Exists(path))
            {
                Console.WriteLine($"Cannot process the file because directory not exists.");
                return null;
            }

            MemoryStream memoryStream = new MemoryStream();
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                fileStream.CopyTo(memoryStream);
                fileStream.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine($"Cannot process the file {path}. Message: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong: {path}.  Message: {e.Message}");
            }
            finally
            {
                if( fileStream != null)
                {
                    fileStream.Dispose();
                }
            }
            return memoryStream;
        }
    }
}
