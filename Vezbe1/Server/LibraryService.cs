using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class LibraryService : ILibrary
    {
        public bool AddNewBook(Book book)
        {
            bool canBeAdded = !Database.CollectionOfBooks.ContainsKey(book.Id);
            if (canBeAdded)
            {
                Database.CollectionOfBooks.Add(book.Id, book);
            }
            return canBeAdded;
        }

        public void DeleteBook(int id)
        {
            if (!Database.CollectionOfBooks.Remove(id))
            {
                throw new FaultException<CustomException>(new CustomException("Book doesn't exists"));
            }
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooksByAuthor(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByGener(Genre genre)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByYear(int year)
        {
            throw new NotImplementedException();
        }
    }
}
