using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class StudentReader : Reader
    {
        public StudentReader(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }

        public override void TakeBook()
        {
            base.TakeBook();
            Console.WriteLine("Student took book");
        }
    }
}
