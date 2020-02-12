using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var dict = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };
        foreach(var x in sequence)
        {
            if(!"ACGT".Contains(x.ToString()))
            {
                throw new ArgumentException("Invalid sequence.");
            }
            dict[x]++;
        }
        return dict;
    }
}