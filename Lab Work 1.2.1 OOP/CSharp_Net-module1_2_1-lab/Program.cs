using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8) declare 2 objects. Use default and paremeter constructors
            LibraryUser libraryUser1 = new LibraryUser("Artem", "Goloborodko","00000001","06765658151", 7);
            LibraryUser libraryUser2 = new LibraryUser();

            // 9) do operations with books for all users: run all methods for both objects
            Console.WriteLine("Program, that simulate library activity"); 
            Console.WriteLine(new string('*', 70));

            Console.WriteLine("user 1: \nFirstName: {0}, LastName: {1}, ID: {2}, Phone: {3}, BookLimit: {4} ", libraryUser1.FirstName, libraryUser1.LastName, libraryUser1.Id, libraryUser1.Phone, libraryUser1.BookLimit);

            libraryUser1.AddBook("book1");
            libraryUser1.AddBook("book2");
            libraryUser1.AddBook("book4");
            libraryUser1.AddBook("book2");
            libraryUser1.AddBook("book3");

            libraryUser1.RemoveBook("book5");
            libraryUser1.RemoveBook("book4");

            libraryUser1.BookInfo(5);
            libraryUser1.BookInfo(1);

            Console.WriteLine("BooksCount :{0}", libraryUser1.BooksCount());

            Console.WriteLine(new string('*', 70));

            Console.WriteLine("user 2: \nFirstName: {0}, LastName: {1}, ID: {2}, Phone: {3}, BookLimit: {4} ", libraryUser2.FirstName, libraryUser2.LastName, libraryUser2.Id, libraryUser2.Phone, libraryUser2.BookLimit);

            libraryUser2.AddBook("book1");
            libraryUser2.AddBook("book2");
            libraryUser2.AddBook("book4");
            libraryUser2.AddBook("book3");
            libraryUser2.AddBook("book6");

            libraryUser2.RemoveBook("book1");

            Console.WriteLine("BooksCount :{0}", libraryUser2.BooksCount());
            ;

            Console.ReadLine();


        }
    }
}
