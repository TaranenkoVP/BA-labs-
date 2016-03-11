using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) Create an arary of Animal objects and object of Animals    
            // print animals with foreach operator for object of Animals               
            Animal[] animal = new Animal[5];
            animal[0] = new Animal("Dog", 30);
            animal[1] = new Animal("Cat", 7);
            animal[2] = new Animal("Cow", 1200);
            animal[3] = new Animal("Tiger", 500);
            animal[4] = new Animal("Lion", 600);

            Animals zoo = new Animals(animal);
            Console.WriteLine("Animals:");
            print(zoo);

            // 11) Invoke 3 types of sorting 
            // and print results with foreach operator for array of Animal objects              
            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Sorting by genus:" );
            Array.Sort(animal);
            print(zoo);

            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Sorting by weigh ascending:");
            Array.Sort(animal, Animal.SortWeightAscending);
            print(zoo);

            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Sorting by genus descending:");
            Array.Sort(animal, Animal.SortGenusDescending);
            print(zoo);

            Console.ReadLine();
        }

        private static void print(Animals zoo)
        {
            foreach (Animal animal in zoo)
            {
                Console.WriteLine("{0} {1}", animal.Genus, animal.Weight);
            }
        }

    }
}
