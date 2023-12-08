using System;
using System.Collections.Generic;
using System.Threading;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Reader> allReaders = new List<Reader>();

            MainMenu();

            //readkey
            Console.WriteLine();
            Console.WriteLine("END");
            Console.ReadKey();
        }
        static void PrintAvaliableBooks()
        {
            Console.Clear();

            Console.WriteLine("Avaliable books");
            for (int i = 0; i < Book.AvailableBooks.Count; i++)
            {
                Console.WriteLine($"Title {i + 1}: {Book.AvailableBooks[i].Title} ({Book.AvailableBooks[i].Genre})");
            }
        }
        static void PrintReaders()
        {
            Console.Clear();

            Console.WriteLine("READERS");
            Console.WriteLine("----------");

            foreach (var item in Reader.allReaders)
            {
                Console.WriteLine();
                if (item is StudentReader)
                {
                    Console.WriteLine("STUDENT READER");
                    Console.WriteLine("----------");
                }
                else if (item is RegularReader)
                {
                    Console.WriteLine("REGULAR READER");
                    Console.WriteLine("----------");
                }
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Phone: {item.Phone}");

                Console.WriteLine();

                Console.WriteLine("Taken books:");
                foreach (var book in item.takenBooks)
                {
                    Console.WriteLine($"{book.Title} ({book.Genre})");
                }

            }
        }
        static void MainMenu()
        {
            Console.Clear();

            Console.WriteLine("1.Add new book");
            Console.WriteLine("2.Add new reader");
            Console.WriteLine("3.Take a book");
            Console.WriteLine("4.Print books");
            Console.WriteLine("5.Print readers");

            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                AddNewBookMenu();
            }
            else if (choise == 2)
            {
                ChooseReaderTypeMenu();
            }
            else if (choise == 3)
            {
                ChooseWhoTakeBookMenu();
            }
            else if (choise == 4)
            {
                PrintAvaliableBooks();

                Console.Write("Press any key...");
                Console.ReadKey();

                MainMenu();
            }
            else if (choise == 5)
            {
                PrintReaders();

                Console.WriteLine();
                Console.Write("Press any key...");
                Console.ReadKey();

                MainMenu();
            }
            else
            {

                Console.WriteLine();
                Console.WriteLine("ERROR");
                Thread.Sleep(2000);

                MainMenu();
            }
        }
        static void AddNewBookMenu()
        {
            Console.Clear();

            Console.WriteLine("Enter book title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter genre (science, crime, romance): ");
            string genre = Console.ReadLine();
            
            if (genre == "Science" || genre == "science")
            {
                Book_Science scienceBook = new Book_Science(title);

                Book.AvailableBooks.Add(scienceBook);
            }
            else if (genre == "Crime" || genre == "crime")
            {
                Book_Crime crimeBook = new Book_Crime(title);
                Book.AvailableBooks.Add(crimeBook);
            }
            else if (genre == "Romance" || genre == "romance")
            {
                Book_Romance romanceBook = new Book_Romance(title);
                Book.AvailableBooks.Add(romanceBook);
            }
            else
            {
                Console.WriteLine("ERROR");
                Thread.Sleep(2000);

                MainMenu();
            }


            Console.WriteLine("Succesfully added new book!");
            Thread.Sleep(2000);

            MainMenu();
        }
        static void ChooseReaderTypeMenu()
        {
            Console.Clear();

            Console.WriteLine("1.Regular reader");
            Console.WriteLine("2.Student reader");

            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                AddNewRegularReader();
            }
            else if (choise == 2)
            {
                AddNewStudentReader();
            }
            else
            {
                Console.WriteLine("ERROR");
                Thread.Sleep(2000);

                MainMenu();
            }
        }
        static void AddNewRegularReader()
        {
            Console.Clear();

            Console.WriteLine("Regular reader");
            Console.WriteLine("----------");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            RegularReader regularReader = new RegularReader(name, phone);

            Reader.allReaders.Add(regularReader);
            

            Console.WriteLine("Succesfully added new Regular reader!");
            Thread.Sleep(2000);

            MainMenu();
        }
        static void AddNewStudentReader()
        {
            Console.Clear();

            Console.WriteLine("Student reader");
            Console.WriteLine("----------");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            StudentReader studentReader = new StudentReader(name, phone);

            Reader.allReaders.Add(studentReader);

            Console.WriteLine("Succesfully added new Student reader!");
            Thread.Sleep(2000);

            MainMenu();
        }
        static void ChooseWhoTakeBookMenu()
        {
            Console.Clear();

            Console.Write("Who want to take book (name of reader): ");
            string name = Console.ReadLine();

            foreach (var item in Reader.allReaders)
            {
                if (item.Name == name)
                {
                    TakeBookMenu(item);
                    break;
                }
            }
        }
        static void TakeBookMenu(Reader reader)
        {
            Console.Clear();

            Console.WriteLine(reader.Name.ToUpper());

            reader.TakeBook();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            MainMenu();
        }
    }
}
