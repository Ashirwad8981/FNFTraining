
using System;
using System.Collections.Generic;
using System.Linq;

class WordFrequencyCounter
{
    //Counting...
    public static Dictionary<string, int> CountFrequencies(string input)
    {
        var wordFreq = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        string[] words = input
            .Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            string w = word.ToLower();
            if (wordFreq.ContainsKey(w))
                wordFreq[w]++;
            else
                wordFreq[w] = 1;
        }

        return wordFreq;
    }

    // Sorting...
    public static List<KeyValuePair<string, int>> SortFrequencies(Dictionary<string, int> freqMap)
    {
        return freqMap
            .OrderByDescending(kvp => kvp.Value)
            .ThenByDescending(kvp => kvp.Key) // Reverse alphabetical
            .ToList();
    }

    // Printing...
    public static void PrintFrequencies(List<KeyValuePair<string, int>> sortedFreq)
    {
        if (sortedFreq.Count == 0)
        {
            Console.WriteLine("0");
            return;
        }

        foreach (var kvp in sortedFreq)
        {
            Console.WriteLine($"{kvp.Value} {kvp.Key}");
        }
    }

    // Main Function...
    static void Main()
    {
        Console.WriteLine("Enter the Sentence : ");
        string input = Console.ReadLine();
        var freqMap = CountFrequencies(input);
        var sortedFreq = SortFrequencies(freqMap);
        PrintFrequencies(sortedFreq);
    }
}