using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class LibraryService : ILibrary
    {
        private readonly LibrarySubscriber subscriber = new LibrarySubscriber();
        public event BookScoreHandler BookScoreChanged;

        private readonly string fileDirectoryPath = ConfigurationManager.AppSettings["bookPath"];

        [OperationBehavior(AutoDisposeParameters = true)]
        public void AddBookRecommendation(FileManipulationOptions options)
        {
            try
            {
                if (!Directory.Exists(fileDirectoryPath)
                {
                    Directory.CreateDirectory(fileDirectoryPath);
                }

                if(options.MemoryStream == null || options.MemoryStream.Length == 0)
                {
                    throw new FaultException<CustomException>(new CustomException($"No content provided for book {options.FileName}"));
                }

                SaveFile(options.MemoryStream,$"{fileDirectoryPath}/{options.FileName}");
            }catch (Exception ex)
            {
                throw new FaultException<CustomException>(new CustomException(ex.Message));

            }
        }

        public void ChangeScore(string title, int score)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public void Subscribe()
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe()
        {
            throw new NotImplementedException();
        }
    }
}
