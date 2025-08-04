using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon
{
    internal class HackathonP1
    {
        static void wordFrequencyIndicator(string str)
        {

            string[] words = str.Split(' ');
            int size = words.Length;
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    if (words[i] == words[j])
                    {
                        arr[i]++;
                    }
                }
            }


            

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            for (int i = 0; i < size; i++)
            {
                keyValuePairs.Add(words[i], arr[i]);
            }
            foreach (KeyValuePair<string, int> kvp in keyValuePairs) {

                Console.WriteLine(kvp.Key+" "+kvp.Value);
            }
        }
        

            static void Main(string[] args)
            {
                Console.WriteLine("Enter the Sentence");
                string str = Console.ReadLine();
                wordFrequencyIndicator(str);
            }
        




















    }
}
