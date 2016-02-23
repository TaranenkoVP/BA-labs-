using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{
    // 2) declare class LibraryUser, it implements ILibraryUser

    class LibraryUser : ILibraryUser
    {
        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)

        private string firstName;
        private string lastName;
        private string id; 
        private string phone;
        private int bookLimit;

        public string FirstName
        {
            get
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public int BookLimit
        {
            get
            {
                return bookLimit;
            }
        }

        // 4) declare field (bookList) as a string array

        private string[] bookList;

        // 5) declare indexer BookList for array bookList

        public string this[int index]
        {
            get
            {
                string temp;
                if (index >= 0 && index < BookLimit)
                {
                    temp = bookList[index];
                }
                else
                {
                    temp = "";
                }
                return temp;
                
            }
            set
            {
                if (index >= 0 && index < BookLimit)
                {
                    bookList[index] = value;
                }
            }
        }

        // 6) declare constructors: default and parameter

        public LibraryUser()
        {
            //RV: No need to initialize them with fake values. They are not useful. Just leave it empty.
            firstName = "defFirstName";
            lastName = "defLastName";
            id = "defID";
            this.phone = "defPhone";
            this.bookLimit = int.MaxValue;
        }

        public LibraryUser(string firstName, string lastName, string id, string phone, int bookLimit)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.phone = phone;
            this.bookLimit = bookLimit;
        }

        private int indexByinfo(string name)
        {
            int index = -1;
            for (int i = 0; i < bookList.Length; i++)
            {
                if (bookList[i] == name)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        // 7) declare methods: 
        //AddBook() – add new book to array bookList,

        public void AddBook(string name)
        {            
            //RV: You can initialize bookList with empty array in constructor to simplify this condition
            if (bookList == null)
            {
                if (BookLimit > 0)
                {
                    bookList = new string[1];
                    bookList[0] = name;
                    Console.WriteLine(@"Book ""{0}"" has been added.", name);
                }
                else
                {
                    Console.WriteLine("Book hasn't been added. Books limit = 0");
                }
            }
            else
            {
                if (indexByinfo(name) >= 0) //check name in array
                {
                    Console.WriteLine(@"Book ""{0}"" has been already added.", name);
                }
                else
                {
                    if (bookList.Length < BookLimit)
                    {
                        string[] tempBookList = new string[bookList.Length + 1];
                        Array.Copy(bookList, tempBookList, bookList.Length);
                        tempBookList[bookList.Length] = name;

                        bookList = tempBookList;
                        Console.WriteLine(@"Book ""{0}"" has been added.", name);
                    }
                    else
                    {
                        Console.WriteLine("Book hasn't been added. There are(is) {0} book(s) of {1} acceptable.", bookList.Length, BookLimit);
                    }
                }
            }
         }

        //RemoveBook() – remove book from array bookList,

        public void RemoveBook(string name)
        {
            if (bookList != null)
            {
                if (indexByinfo(name) >= 0) //check name in array
                {
                    string[] tempBookList = new string[bookList.Length -1];
                    int i = 0;
                    foreach (string str in bookList)
                    {
                        if (str != name)
                        {
                            tempBookList[i] = str;
                            i++;
                        }
                    }
                    bookList = tempBookList;
                    Console.WriteLine("The book {0} has been removed", name);
                }
                else
                {
                    Console.WriteLine("The user {0} {1} doesn't have this book", FirstName, LastName);
                }
            }
            else
            {
                Console.WriteLine("The user {0} {1} doesn't have any books", FirstName, LastName);
            }
        }
        //BookInfo() – returns book info by index,

        public string BookInfo(int index)
        {
            string tempstr = "";
            bool flagfound = false;

            if (bookList != null)
            {
                if (index < bookList.Length && index > 0)
                {
                    tempstr = bookList[index];
                    flagfound = true;
                    Console.WriteLine("The book by index {0} : {1} ", index, tempstr);
                }
            }

            if (!flagfound)
            {
                Console.WriteLine("The book by index {0} hasn't been found", index);
            }
            return tempstr;
        }

        //BooksCout() – returns current count of books
        public int BooksCount()
        {
            return ( (bookList == null) ? 0 : bookList.Length );
        }
    }
}
