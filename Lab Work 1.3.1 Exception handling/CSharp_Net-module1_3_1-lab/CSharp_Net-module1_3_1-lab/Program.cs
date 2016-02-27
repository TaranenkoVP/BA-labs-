using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class Program
    {
        static int t(int a )
        {

            return a * t(a + 1);
        }

        static void Main(string[] args)
        {
            CatchExceptionClass cec = new CatchExceptionClass();
            cec.CatchExceptionMethod();

            // 11) Make some unhandled exception and study Visual Studio debugger report – 
            // read description and find the reason of exception
           // try
           // {
           //   t(299999999);
           // }
           // catch (Exception e)
           // {
           //    Console.WriteLine(e.Message);
           // }
            Console.ReadLine();
        }
    }
}
