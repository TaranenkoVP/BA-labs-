using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{
    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser

    public interface ILibraryUser
    {
        void AddBook(string name);
        void RemoveBook(string name);
        string BookInfo(int index);
        int BooksCount();
    }

}
