using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if ( sliceLength > numbers.Length || (numbers.Length == 0 && sliceLength > 0) || 
            sliceLength <= 0  || Regex.Match(numbers, @"\D").Success)
        {
            throw new ArgumentException("Argument Error");
        } 
        List<string> series = new List<string>(); 
        for ( int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            series.Add(numbers.Substring(i, sliceLength));

        }
        return series.ToArray();
    }
}