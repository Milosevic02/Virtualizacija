using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        private void CreateFileSystemWatcher(string path)
        {
            fileWatcher = new FileSystemWatcher()
            {
                Path = path,
                Filter = "*.*",
                NotifyFilter = NotifyFilters.LastWrite
            };

            fileWatcher.Changed += FileChanged;
            fileWatcher.EnableRaisingEvents = true;
        }
    }
}
