using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        List<string> result = new List<string>();
        var proteins = new Dictionary<string, string>()
        {
            {"AUG", "Methionine" },
            {"UUU", "Phenylalanine" }, {"UUC", "Phenylalanine" },
            {"UUA", "Leucine" }, {"UUG", "Leucine" },
            {"UCU", "Serine" }, {"UCC", "Serine" }, {"UCA", "Serine" }, {"UCG", "Serine" },
            {"UAU", "Tyrosine" }, {"UAC", "Tyrosine" },
            {"UGU", "Cysteine" }, {"UGC", "Cysteine" },
            {"UGG", "Tryptophan" }
        };
        for(int i = 0; i < strand.Length - 2; i+=3)
        {
            if(!proteins.ContainsKey(strand.Substring(i, 3)))
            {
                break;
            }
            result.Add(proteins[strand.Substring(i, 3)]);
        }
        return result.ToArray();
    }
}