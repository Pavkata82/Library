using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book_Crime : Book 
    {
        public Book_Crime(string title)
        {
            this.Title = title;
            this.Genre = "Crime";
        }
        public override void AddToCollection()
        {
            base.AddToCollection();
            Console.WriteLine("Added Crime book");
        }
    }
}
