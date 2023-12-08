using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Reader
    {
        public string Name;
        public string Phone;
        public List<Book> takenBooks = new List<Book>();
        static List<Book> books = new List<Book>();
        static public List<Reader> allReaders = new List<Reader>();


        public Reader()
        {

        }
        public Reader(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        public virtual void TakeBook()
        {
            Console.Write("Enter the book you want to take: ");
            string book = Console.ReadLine();

            int searchedIndex = -1;

            for (int i = 0; i < Book.AvailableBooks.Count; i++)
            {
                if (book == Book.AvailableBooks[i].Title)
                {
                    searchedIndex = i;
                    break;
                }
            }

            if (Book.AvailableBooks[searchedIndex] is Book_Science)
            {
                Console.WriteLine($"{this.Name} is interested in Science books!");
            }
            else if (Book.AvailableBooks[searchedIndex] is Book_Crime)
            {
                Console.WriteLine($"{this.Name} is interested in Crime books!");
            }
            else if (Book.AvailableBooks[searchedIndex] is Book_Romance)
            {
                Console.WriteLine($"{this.Name} is interested in Romance books!");
            }
            else
            {
                Console.WriteLine("ERROR (MAYBE THE OBJECT IS FROM CLASS BOOK)");
            }


            books.Add(Book.AvailableBooks[searchedIndex]);
            takenBooks.Add(Book.AvailableBooks[searchedIndex]);
            Book.AvailableBooks.RemoveAt(searchedIndex);
        }
    }
}
