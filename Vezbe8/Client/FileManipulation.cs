using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class FileManipulation
    {
        private FileSystemWatcher inputFileWatcher;
        private string filePath;

        public FileManipulation(string path)
        {
            
        }

        public void DownloadFile(FileManipulationResults results,string fileName)
        {
            using (FileStream fileStream = new FileStream($"{filePath}\\{fileName}", FileMode.Create, FileAccess.Write))
            {
                results.MemoryStream.WriteTo(fileStream);
                fileStream.Dispose();
                results.MemoryStream.Dispose();
                Console.WriteLine($"Downloaded file {fileName}");
            }
        }

        private void FileChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Status:{e.ChangeType} file {e.FullPath} at {DateTime.Now}");
        }

        private void FileRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"File was renamed.Old file:{e.OldName},New file:{e.Name},Time: {DateTime.Now}");
        }

        private void FileDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Status: {e.ChangeType} file {e.FullPath} at {DateTime.Now}");
        }

        private void CreateFileSystemWatcher(string path)
        {
            inputFileWatcher = new FileSystemWatcher()
            {
                Path = path,
                IncludeSubdirectories = true,
                InternalBufferSize = 32768,
                Filter = "*.*",
                NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite
            };
            inputFileWatcher.EnableRaisingEvents = true;

            inputFileWatcher.Changed += FileChanged;
            inputFileWatcher.Renamed += FileRenamed;
            inputFileWatcher.Deleted += FileDeleted;    




    }
}
