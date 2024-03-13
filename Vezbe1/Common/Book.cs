using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    [DataContract]
    public enum Genre
    {
        [EnumMember] Fiction,
        [EnumMember] Fantasy,
        [EnumMember] Tragedy,
        [EnumMember] Unknown
    }


    [DataContract]
    public class Book
    {
        static int count = 1;
        int id;
        string firstName;
        string lastName;
        string bookName;
        Genre genreOfBook;
        DateTime dateOfPublishing;

        public Book(string firstName, string lastName, string bookName, DateTime dateOfPublishing, Genre genreOfBook)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.bookName = bookName;
            this.dateOfPublishing = dateOfPublishing;
            this.genreOfBook = genreOfBook;
            id = count++;
        }

        [DataMember]
        public int Id { get => id; set => id = value; }
        [DataMember]
        public string BookName { get => bookName; set => bookName = value; }
        [DataMember]
        public string FirstName { get => firstName; set => firstName = value; }
        [DataMember]
        public string LastName { get => lastName; set => lastName = value; }
        [DataMember]
        public Genre GenreOfBook { get => genreOfBook; set => genreOfBook = value; }
        [DataMember]
        public DateTime DateOfPublishing { get => dateOfPublishing; set => dateOfPublishing = value; }
    
        
    
    }
}
