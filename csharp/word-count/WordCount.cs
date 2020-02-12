using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        string[] source = phrase.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\n', '&', '@', '$', '%', '^', '&' }, StringSplitOptions.RemoveEmptyEntries); 
        var dict = new Dictionary<string, int>();
        foreach(var word in source)
        {
            var lowercaseWord = word.StartsWith("\'") ? 
                Regex.Replace(word.ToLower(), "^\'|\'$" , "") 
                : word.ToLower();
            if(!dict.ContainsKey(lowercaseWord))
            {
                dict[lowercaseWord] = 0;
            }
            dict[lowercaseWord]++;
        }
        return dict;
    }
}