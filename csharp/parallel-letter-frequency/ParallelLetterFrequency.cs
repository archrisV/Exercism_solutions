using System;
using System.Linq;
using System.Collections.Generic;

public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        return texts.Aggregate("", (x, y) => x + y)
                    .ToLowerInvariant()
                    .Where(x => char.IsLetter(x))
                    .AsParallel()
                    .GroupBy(x => x)
                    .ToDictionary(x => x.Key, x => x.Count());
    }
}