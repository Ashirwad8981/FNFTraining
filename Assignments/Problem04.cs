using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Problem04
    {
        static void implementTheArray(int size, string dataType) {

            if (dataType == "int")
            {
                int[] array1 = new int[size];
                for (int i = 0; i < size; i++)
                {
                    //int[] array1 = new int[size];
                    array1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Array elements are as follow : ");
                foreach (int i in array1)
                {
                    Console.WriteLine(i);

                }

            }
            if (dataType == "char")
            {
                char[] array2 = new char[size];
                for (int i = 0; i < size; i++)
                {
                    //int[] array1 = new int[size];
                    array2[i] = char.Parse(Console.ReadLine());
                }
                Console.WriteLine("Array elements are as follow : ");
                foreach (char i in array2)
                {
                    Console.WriteLine(i);

                }

            }
            if (dataType == "float")
            {
                float[] array3 = new float[size];
                for (int i = 0; i < size; i++)
                {
                    //int[] array1 = new int[size];
                    array3[i] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine("Array elements are as follow : ");
                foreach (float i in array3)
                {
                    Console.WriteLine(i);

                }

            }
            if (dataType == "string")
            {
                string[] array4 = new string[size];
                for (int i = 0; i < size; i++)
                {
                    //int[] array1 = new int[size];
                    array4[i] = Console.ReadLine();
                }
                Console.WriteLine("Array elements are as follow : ");
                foreach (string i in array4)
                {
                    Console.WriteLine(i);

                }

            }


        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of array(int,float,char,string)");
            string dataType = Console.ReadLine().ToLower();
            implementTheArray(size, dataType);

        }
    }
}
