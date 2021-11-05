using System;
using System.Collections.Generic;
using System.Linq;

namespace MobyDickWordCounter
{
    public static class WordCounter
    {
        public static IEnumerable<Tuple<string, int>> GetWordOccurences(string text)
        {
            var words = text.Split(" ", 
                StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            var resultTuples = words
                .GroupBy(x => x)
                .Where(x => x.Key.Length > 1)
                .Select(x => new Tuple<string, int>(x.Key, x.Count()))
                .OrderByDescending(x => x.Item2)
                .Take(20);
            
            return resultTuples;
        }
    }
}