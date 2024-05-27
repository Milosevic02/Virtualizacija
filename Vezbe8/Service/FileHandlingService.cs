using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class FileHandlingService : IFileHandler
    {
        public FileManipulationResults GetFile(FileManipulationOptions options)
        {
            var results = new FileManipulationResults();

            try
            {
                var fileDirectoryPath = ConfigurationManager.AppSettings["path"];
                if (!File.Exists($"{fileDirectoryPath}/{options.SearchedFile}"))
                {
                    results.ResultType = ResultTypes.Warning;
                    results.ResultMessage = "There are no file or directory for you on service";
                    return results;
                }
                AddMemoryStream($"{fileDirectoryPath}/{options.SearchedFile}", options.SearchedFile, results);
            }
            catch (Exception e)
            {
                results.ResultType = ResultTypes.Failed;
                results.ResultMessage = e.Message;
            }

            return results;
        }

        private void AddMemoryStream(string filePath,string keyWord,FileManipulationResults results)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                MemoryStream ms = new MemoryStream();
                fileStream.CopyTo(ms);
                results.MemoryStream = ms;
            }
        }
    }
}
