using Common;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
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
