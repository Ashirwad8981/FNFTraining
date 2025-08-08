using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Problem02
    {

        static void checkEvenOdd(int[] array, int size) {
            foreach (int i in array) {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"The number : {i} is even.");
                }
                
                else { 

                     Console.WriteLine($"The number : {i} is odd.");
}
            
            }
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] array= new int[size];

            for (int i = 0; i < size; i++) {

                array[i]=int.Parse(Console.ReadLine());
       
            }
            checkEvenOdd(array, size);
        }
    }
}
