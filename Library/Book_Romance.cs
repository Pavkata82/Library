using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book_Romance : Book
    {
        public Book_Romance(string title)
        {
            this.Title = title;
            this.Genre = "Romance";
        }

        public override void AddToCollection()
        {
            base.AddToCollection();
            Console.WriteLine("Added Romance book");
        }
    }
}
