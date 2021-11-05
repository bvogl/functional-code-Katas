using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace MobyDickWordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var countedWords = WordCounter.GetWordOccurences(File.ReadAllText("MobyDick.txt"));

            countedWords.ToList().ForEach((x) => Console.WriteLine($"{x.Item1}: \t{x.Item2}"));
        }
    }
}