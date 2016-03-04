using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Generics_stud
{
    public class Base<T> where T : new()
    {
       static Base()
       {
            T a = new T();
            Console.WriteLine("Base static constructor");
       }
    }

    public sealed class Derived : Base<Derived>
    {
        public Derived()
        {
            Console.WriteLine("Derived constructor");
        }
    }
}
