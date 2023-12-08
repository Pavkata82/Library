using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string Title;
        public string Genre;
        public static List<Book> AvailableBooks = new List<Book>();


        public Book()
        {

        }
        public Book(string title, string genre)
        {
            this.Title = title;
            this.Genre = genre;
        }

        public virtual void AddToCollection()
        {
            AvailableBooks.Add(this);
        }
    }
}
