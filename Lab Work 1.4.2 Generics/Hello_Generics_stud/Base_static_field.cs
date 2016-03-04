using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Generics_stud
{
    public class Base_static_field<T> where T : new()
    {
        private static T _instance;
        public static T Instance
        {
            get
            {
                Console.WriteLine("Public field");
                _instance = new T();
                return _instance;
            }
        }

        protected Base_static_field()
        {
            Console.WriteLine("Protected Base_static_field constructor ");
        }
    }

    public sealed class Derived_static_field : Base_static_field<Derived_static_field>
    {
        public Derived_static_field()
        {
            Console.WriteLine("Derived_static_field constructor ");
        }
     }
}
