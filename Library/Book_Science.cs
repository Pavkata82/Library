using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book_Science : Book
    {
        public Book_Science(string title)
        {
            this.Title = title;
            this.Genre = "Science";
        }
        public override void AddToCollection()
        {
            base.AddToCollection();
            Console.WriteLine("Added Science book");
        }
    }
}
