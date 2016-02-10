using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, sb, sh, ush, i, ui, l, ul, de, fl, do
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            bool boo = true;
            char ch = 'c';
            byte b = 1;
            sbyte sb = 100;
            short sh = 250;
            ushort ush = 150;
            int i = 10000;
            uint ui = 25;
            long l = -223;
            ulong ul = 300;
            decimal de = 100000.6M;
            float fl = 8;
            //double do = -33.1; compilation error
            double @do = -33.1;

            //2) declare constants of int and double. Try to change their values.

            const int a = 1;
            const double d = 1.1d;
            // a = 2; compilation error(cant change constants values)
            // d = 2.1; compilation error(cant change constants values)

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            var x = 20;
            var y = 20.5;
            //x = 20.5; compilation error(x was declared of int type)
            y = 20;

            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and do. Is it possible?

            System.Int32 si32;
            System.Double sd;
            si32 = i;
            //sd = do; compilation error(should use @do)

            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                //int i; can not be declared in this scope,variable already exist
                //char ch; can not be declared in this scope,variable already exist
                //double do; compilation error(should use @do)

                // 6) change values of variables from 1)

                i = -12504;
                ch = 'f';
            }

            // 7)check values of variables from 1). Are they changed? Think, why

            //They are changed.

            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 
            // Fix compilation errors (in case of impossible conversion commemt that line).
           
            ch = (char)i; // Warning! Possible loss of data/
            // You can't convert bool to short
            l = (long)@do; // Warning! Precision but not magnitude might be lost in the conversion 
            ch = (char)fl; // Warning! Possible loss of data/
            @do = (double)de; // Warning! When we convert decimal to float or double, the decimal value is rounded to the nearest double or float value.
            ui = b;
            sb = (sbyte)ul; // Warning! Possible loss of data/

            // 9) and reverse conversion with fixing compilation errors.

            i = ch;
            //you can't convert short to bool
            @do = l;
            fl = ch;
            de = (decimal)@do; //Warning! Possible OverflowException or loss of data
            b =(byte)ui; // Warning! Possible loss of data
            ul = (ulong)sb; // Warning! Possible loss of data/

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?

            int? n = null;
            //i = null; impossible;
            Console.ReadLine();
        }
    }
}
