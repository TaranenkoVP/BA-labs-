using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            4. Quess
            ");
            
            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                case 4:
                    QuessNumber();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {
            //The correct sequence of answers is 3827183 or 3817283
            int input, input3, input5 = 0;
            int step1 = 3, step2 = 8, stap3_FirstWay = 1, step3_SecondWay = 2, step4 = 7, stap5_FirstWay = 2, step5_SecondWay = 1, step6 = 8, step7 = 3;

            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("There: farmer and wolf - 1");
            Console.WriteLine("There: farmer and cabbage - 2");
            Console.WriteLine("There: farmer and goat - 3");
            Console.WriteLine("There: farmer  - 4");
            Console.WriteLine("Back: farmer and wolf - 5");
            Console.WriteLine("Back: farmer and cabbage - 6");
            Console.WriteLine("Back: farmer and goat - 7");
            Console.WriteLine("Back: farmer  - 8");
            Console.WriteLine(new string('*', 30));

            Console.WriteLine("Please, type first step: ");

            input = int.Parse(Console.ReadLine());
            if (input == step1)
            {
                Console.WriteLine("Please, type next step");
                input = int.Parse(Console.ReadLine());

                if (input == step2)
                {
                    Console.WriteLine("Please, type next step");
                    input3 = int.Parse(Console.ReadLine());

                    if ((input3 == stap3_FirstWay) | (input3 == step3_SecondWay))
                    {
                        Console.WriteLine("Please, type next step");
                        input = int.Parse(Console.ReadLine());

                        if (input == step4)
                        {
                            Console.WriteLine("Please, type next step");
                            input5 = int.Parse(Console.ReadLine());


                            if (((input5 == stap5_FirstWay) & (input3 == stap3_FirstWay)) | ((input5 == step5_SecondWay) & (input3 == step3_SecondWay)))
                            {
                                Console.WriteLine("Please, type next step");
                                input = int.Parse(Console.ReadLine());

                                if (input == step6)
                                {
                                    Console.WriteLine("Please, type next step");
                                    input = int.Parse(Console.ReadLine());

                                    if (input == step7)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Correct way!");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Wrong way!");
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Wrong way!");
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Wrong way!");
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong way!");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong way!");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong way!");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong way!");
            }
        }
        #endregion

        #region calculator
        static void Calculator()
        {
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Console Calculator:");
            Console.WriteLine(new string('*', 30));
            Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Choose action:");
            string operation = Console.ReadLine();
            double a, b;
            try
            {
                Console.WriteLine("Type the first value");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Type the second value");
                b = double.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Green;

                switch (operation)
                {
                    case "1":
                        Console.WriteLine("The result = {0}", a * b);
                        break;
                    case "2":
                        if (b == 0)
                            throw new Exception("Cannot divide by 0");
                        else
                            Console.WriteLine("The result = {0}", a / b);
                        break;
                    case "3":
                        Console.WriteLine("The result = {0}", a + b);
                        break;
                    case "4":
                        Console.WriteLine("The result = {0}", a - b);
                        break;
                    case "5":
                        Console.WriteLine("The result = {0}", Math.Pow(a, b));
                        break;
                    default:
                        throw new Exception("The unknown operation!");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Factorial calculation:");
            Console.WriteLine(new string('*', 30));
            //first way
            int number;
            int factorial = 1;
            Console.WriteLine("Type the number");
            number = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            while (number > 1)
                factorial *= number--;

            Console.WriteLine("The result = " + factorial);

        }
        #endregion

        #region QuessNumber
        static void QuessNumber()
        {
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Guess the Number");
            Console.WriteLine(new string('*', 30));

            Random rand = new Random();
            int answer = rand.Next(1, 200);
            int atempt = 0;

            do
            {
                var consoleColors = Enum.GetValues(typeof(ConsoleColor));
                Console.ForegroundColor = (ConsoleColor)consoleColors.GetValue(rand.Next(consoleColors.Length));
                if (Console.ForegroundColor == ConsoleColor.Black)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("Enter your guess: ");
                atempt = Convert.ToInt32(Console.ReadLine());
                if (atempt < answer)
                {
                    Console.WriteLine("{0} - Too low!", atempt);
                }
                else if (atempt > answer)
                {
                    Console.WriteLine("{0} - Too high!", atempt);
                }
            } while (answer != atempt);

            Console.WriteLine("{0} - is right! Congratulations.", answer);
        }
        #endregion

    }
}
