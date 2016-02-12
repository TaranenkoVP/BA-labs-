using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType
        enum ComputerType { Desktop, Laptop, Server };

        // 2) declare struct Computer
        struct Computer
        {
            public ComputerType type;
            public int cpu, memory, hdd;
            public float frequency;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Develop the program, which helps to manage computers in organization:");
            Console.WriteLine(new string('*', 70));

            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[][] departments = new Computer[4][];

            // 4) set the size of every array in jagged array (number of computers)

            departments[0] = new Computer[5];
            departments[1] = new Computer[3];
            departments[2] = new Computer[5];
            departments[3] = new Computer[4];

            // 5) initialize array
            // Note: use loops and if-else statements

            departments[0][0].type = ComputerType.Desktop;
            departments[0][1].type = ComputerType.Desktop;
            departments[0][2].type = ComputerType.Laptop;
            departments[0][3].type = ComputerType.Laptop;
            departments[0][4].type = ComputerType.Server;

            departments[1][0].type = ComputerType.Laptop;
            departments[1][1].type = ComputerType.Laptop;
            departments[1][2].type = ComputerType.Laptop;

            departments[2][0].type = ComputerType.Desktop;
            departments[2][1].type = ComputerType.Desktop;
            departments[2][2].type = ComputerType.Desktop;
            departments[2][3].type = ComputerType.Laptop;
            departments[2][4].type = ComputerType.Laptop;

            departments[3][0].type = ComputerType.Desktop;
            departments[3][1].type = ComputerType.Laptop;
            departments[3][2].type = ComputerType.Server;
            departments[3][3].type = ComputerType.Server;

            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].type == ComputerType.Laptop)
                    {
                        departments[i][j].cpu = 2;
                        departments[i][j].frequency = 1.7f;
                        departments[i][j].memory = 4;
                        departments[i][j].hdd = 250;
                    }
                    else if (departments[i][j].type == ComputerType.Desktop)
                    {
                        departments[i][j].cpu = 4;
                        departments[i][j].frequency = 2.5f;
                        departments[i][j].memory = 6;
                        departments[i][j].hdd = 500;
                    }
                    else if (departments[i][j].type == ComputerType.Server)
                    {
                        departments[i][j].cpu = 8;
                        departments[i][j].frequency = 3.0f;
                        departments[i][j].memory = 16;
                        departments[i][j].hdd = 2000;
                    }
                }
            }

            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)

            int amountAll = 0, amountDesktop = 0, amountLaptop = 0, amountServer = 0;

            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    switch (departments[i][j].type)
                    {
                        case ComputerType.Laptop:
                            amountLaptop++;
                            break;

                        case ComputerType.Desktop:
                            amountDesktop++;
                            break;

                        case ComputerType.Server:
                            amountServer++;
                            break;
                        default:
                            break;
                    }

                    amountAll++;
                }
            }
            Console.WriteLine("total number of Laptops: {0}", amountLaptop);
            Console.WriteLine("total number of Desktops: {0}", amountDesktop);
            Console.WriteLine("total number of Servers: {0}", amountServer);
            Console.WriteLine("total number of all computers: {0}", amountAll);

            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements

            int largestHHD = 0;
            int[] posLargeStorage = new int[2];

            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].hdd > largestHHD)
                    {
                        largestHHD = departments[i][j].hdd;
                        posLargeStorage[0] = i;
                        posLargeStorage[1] = j;
                    }
                }
            }
            Console.WriteLine("computer with the largest storage (HDD) has index [{0}][{1}]", posLargeStorage[0], posLargeStorage[1]);

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions

            int lowestCPU = departments[0][0].cpu, lowestMemory = departments[0][0].memory;

            int[] positionLowest = new int[2];

            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                     if ((departments[i][j].cpu < lowestCPU) && (departments[i][j].memory < lowestMemory))
                    {
                        lowestMemory = departments[i][j].memory;
                        lowestCPU = departments[i][j].cpu;
                        positionLowest[0] = i;
                        positionLowest[1] = j;
                    }
                }
            }
            Console.WriteLine("computer with the lowest productivity (CPU and memory) has index [{0}][{1}]", positionLowest[0], positionLowest[1]);

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements
            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].type == ComputerType.Desktop)
                    {
                        departments[i][j].memory = 8;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
