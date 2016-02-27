using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_3_1_lab
{
    class MyArray
    {
        int[] arr;

        public void Assign(int []arr, int size)
        {
            // 5) add block try (outside of existing block try)
            try
            {
                try
                {
                    this.arr = new int[size];
                    //for (int i = 0; i < arr.Length; i++)
                    //    this.arr[i] = arr[i] / arr[i + 1];

                    // 1) assign some value to cell of array int_array, which index is out of range
                    //this.arr[arr.Length] = 10;

                    // 7) use unchecked to assign result of operation 1000000000 * 100 
                    // to last cell of array
                    unchecked
                    {
                        this.arr[arr.Length - 1] = 1000000000 * 100;
                    }

                }
                 // 2) catch exception index out of rage
                catch (IndexOutOfRangeException)
                {
                    // output message 
                    Console.WriteLine("Exception: index out of rage. ");
                }

                // 4) catch devision by 0 exception
                catch (DivideByZeroException)
                {
                    // output message 
                    Console.WriteLine("Exception:  devision by 0. ");
                }

                //string s = null;
                //Console.WriteLine(s.Length); 
            }
            
            // 6) add catch block for null reference exception of outside block try  
            // change the code to execute this block (any method of any class)
            catch (NullReferenceException)
            {
                Console.WriteLine("Exception: null reference. ");
            } 
        }
    }
}
