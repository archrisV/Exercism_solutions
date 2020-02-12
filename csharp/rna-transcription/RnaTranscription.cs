using System;
using System.Linq;
using System.Collections.Generic;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var dict = new Dictionary<string, string>
        {           
            {"G", "C"},
            {"C", "G"},
            {"T", "A"},
            {"A", "U"}
        };
        return String.Join("", nucleotide.Select(x => dict[x.ToString()]).ToArray());
    }
}