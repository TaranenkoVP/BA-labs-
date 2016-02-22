using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program, that simulates money operations");
            Console.WriteLine(new string('*', 70));

            // 10) declare 2 objects
            Money money1 = new Money(CurrencyTypes.UAH, 400);
            Money money2 = new Money(CurrencyTypes.UAH, 300);

            // 11) do operations
            // add 2 objects of Money
            if (money1 == money2)
            {
                Console.WriteLine("money1 + money2: {1} {0} + {2} {0} = {3} {0}", money1.CurrencyType, money1.Amount, money2.Amount, (money1 + money2).Amount);
            }

            // add 1st object of Money and double
            double d = 150.10d;
            Console.WriteLine("money1 + double: {1} {0} +  {2} = {3} {0}", money1.CurrencyType, money1.Amount,  d, (money1 + d).Amount);

            // decrease 2nd object of Money by 1 
            --money2;
            Console.WriteLine("money2 -- = {1} {0}", money2.CurrencyType, money2.Amount);

            // increase 1st object of Money
            int i = 5;
            Console.WriteLine("money1 * int: {1} * {2} =  {3} {0}", money1.CurrencyType, money1.Amount, i, (money1 * i).Amount);

            // compare 2 objects of Money
            if (money1 == money2)
            {
                if (money1 > money2)
                {
                    Console.WriteLine("money1 > money2: {0} > {1}", money1.Amount, money2.Amount);
                }
                else if (money1 < money2)
                {
                    Console.WriteLine("money1 < money2: {0} < {1}", money1.Amount, money2.Amount);
                }
            }

            // compare 2nd object of Money and string
            string str = "1000";
            if (money2 < str)
            {
                Console.WriteLine("money2 < string: {0} < {1}", money2.Amount, str);
            }
            else 
            {
                Console.WriteLine("money2 > string: {0} > {1}", money2.Amount, str);
            }

            // check CurrencyType of every object
            if (money1)
            {
                Console.WriteLine("money1 true");
            }
            else
            {
                Console.WriteLine("money1 false");
            }

            if (money2)
            {
                Console.WriteLine("money2 true");
            }
            else
            {
                Console.WriteLine("money2 false");
            }

            // convert 1st object of Money to string
            str = money1;
            Console.WriteLine("string: " + str);

            Console.ReadLine();  
        }
    }
}
