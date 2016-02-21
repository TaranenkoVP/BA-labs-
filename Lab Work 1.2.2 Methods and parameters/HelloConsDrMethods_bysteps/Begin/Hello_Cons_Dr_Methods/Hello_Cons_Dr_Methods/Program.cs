using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Box a = new Box();

                Console.WriteLine("Type position of the box, x = ");
                a.X = uint.Parse(Console.ReadLine());

                Console.WriteLine("Type position of the box: y = ");
                a.Y = uint.Parse(Console.ReadLine());

                Console.WriteLine("Type width of the box: width = ");
                a.Width = uint.Parse(Console.ReadLine());

                Console.WriteLine("Type height of the box: height = ");
                a.Height = uint.Parse(Console.ReadLine());

                Console.WriteLine("Type symbol (*,+,$,#,@) :");
                a.Symbol = char.Parse(Console.ReadLine());

                Console.WriteLine("Type the message : ");
                a.Message = Console.ReadLine();

                a.Draw();

                Console.WriteLine(a.Message);
                Console.WriteLine();

                Console.WriteLine("Type integer value:");
                Console.WriteLine("Factorial = {0}", factorial(int.Parse(Console.ReadLine())));
                Console.ReadLine();

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invalid parameters!");
                Console.ReadLine();
            }

        }

       static public int factorial(int f)
        {
            return (f == 0) ? 1 : f * factorial(f - 1);
        }
    }
}
