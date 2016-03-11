using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_4_3_lab
{
    //6) implement interface IEnumerable
    class Animals : IEnumerable
    {
        // 7) declare private array of Animal
        private Animal[] itm = null;

        // 8) declare parameter constructor to initialize array
        public Animals(Animal[] animal)
        {
            itm = animal;
        }

        // 9) implement method GetEnumerator(), which returns IEnumerator
        // use foreach on array of Animal
        // and yield return for every animal
        public IEnumerator GetEnumerator()
        {
            foreach (Animal animal in itm)
                yield return animal;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)itm).GetEnumerator();
        }

    }
}
